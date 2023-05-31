using CoffeeRestaurentTeleBot.Services;
using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TeleBot
{
    public partial class TeleBot : Form
    {

        TelegramBotClient botClient;
        int logCounter = 0;

        void AddLog(string msg)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.BeginInvoke((MethodInvoker)delegate ()
                {
                    AddLog(msg);
                });
            }
            else
            {
                logCounter++;
                if (logCounter > 100)
                {
                    txtLog.Clear();
                    logCounter = 0;
                }
                txtLog.AppendText(msg + "\r\n");
            }
        }
        public TeleBot()
        {
            InitializeComponent();
            string token = "5646812256:AAEtg2-9puHUpJfvqjzB-qC65sIiuG5ZhyY";

            //Console.WriteLine("my token=" + token);

            botClient = new TelegramBotClient(token);

            using CancellationTokenSource cts = new();

            // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
            ReceiverOptions receiverOptions = new()
            {
                AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
            };

            botClient.StartReceiving(
                updateHandler: HandleUpdateAsync,  //hàm xử lý khi có người chát đến
                pollingErrorHandler: HandlePollingErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: cts.Token
            );
            Task<User> me = botClient.GetMeAsync();

            AddLog($"Bot begin working: @{me.Result.Username}");


            async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
            {
                // Only process Message updates: https://core.telegram.org/bots/api#message
                bool ok = false;
                Telegram.Bot.Types.Message? message = null;

                if (update.Message != null)
                {
                    message = update.Message;
                    ok = true;
                }

                if (update.EditedMessage != null)
                {
                    message = update.EditedMessage;
                    ok = true;
                }

                if (!ok || message == null) return;

                string? messageText = message.Text;
                if (messageText == null) return;
                var username = message.Chat.Username;
                var chatId = message.Chat.Id;
                AddLog($"{username}: {messageText}");


                string reply = "";
                if (messageText.StartsWith("/help"))
                {

                    //SqlService sqlService = new SqlService();
                    reply = "Hướng dẫn sử dụng bot 🤖 của Coffee Restaurent 😊:\n/order: để được gọi và đặt đồ ăn 🍵🍹\n/menu: để lấy menu của quán nhé 📄\n- Cần hỗ trợ: 0852072574 ☎️";



                }
                else if (messageText.StartsWith("/dl "))
                {
                    string path = messageText.Substring(4);

                    string fn = System.IO.Path.GetFileName(path);
                    reply = $"Đã gửi file {fn} qua telegram rồi, click vào mũi tên để lưu về máy";

                    await using Stream stream = System.IO.File.OpenRead(path);
                    Telegram.Bot.Types.Message fileMessage = await botClient.SendDocumentAsync(
                        chatId: chatId,
                        document: InputFile.FromStream(stream: stream, fileName: fn),
                        caption: $"Download file {path}");
                }
                else if (messageText.StartsWith("/find "))
                {
                    string studentName = messageText.Substring(6);
                    using(SqlService sql = new SqlService())
                    {
                        string query = $@"SELECT mssv, hoten FROM SinhVien WHERE hoten like N'%{studentName}%' OR mssv like N'%{studentName}%'";
                        DataTable dt = sql.GetDataQuery(query);
                        reply = $"Đã tìm thấy {dt.Rows.Count} sinh viên\n";
                        foreach (DataRow row in dt.Rows)
                        {
                            reply += "------------------\n";
                            reply += " Tên: " + row["hoten"].ToString() + "\n";
                            reply += " MSSV: " + row["mssv"].ToString() + "\n";
                            
                        }
                    }
                }
                else
                {
                    reply = "Xin lỗi, tớ không hiểu yêu cầu của bạn, hãy sử dụng /help để được trợ giúp nhé 😊";
                }

                // Echo received message text
                Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                       chatId: chatId,
                       text: reply
                      );
            }

            Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
            {
                var ErrorMessage = exception switch
                {
                    ApiRequestException apiRequestException
                        => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                    _ => exception.ToString()
                };

                AddLog(ErrorMessage);
                return Task.CompletedTask;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TeleBot_Load(object sender, EventArgs e)
        {

        }
    }
}