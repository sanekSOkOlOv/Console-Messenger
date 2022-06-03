using System;
using System.Threading;
using Newtonsoft.Json;

namespace ConsoleMessanger
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessangerClientAPI API = new MessangerClientAPI();

        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }

        static void Main(string[] args)
        {
            MessageID = 1;
            Console.WriteLine("Введите Ваше имя:");
            //UserName = "Sokolov";
            UserName = Console.ReadLine();
            string MessageText = "";

            while (MessageText != "exit")
            {
                GetNewMessages();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(Sendmsg);
                }
            }
        }

        //Message ms = new Message();
        //string output = JsonConvert.SerializeObject(ms);
        //Message deserializedMs = JsonConvert.DeserializeObject<Message>(output);

        //Console.WriteLine(output);
        //Console.WriteLine(deserializedMs.ToString());

        //{ "UserName":"System","MessageText":"Online","TimeStamp":"2022-06-02T12:21:54.219595+03:00"}
        //System < 02.06.2022 12:21:54 > : Online
    }
}
