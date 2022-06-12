using System;

namespace ConsoleMessanger
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }
        public Message()
        {
            UserName = "System";
            MessageText = "Online";
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            string output = String.Format("{0} <{1}> : {2}", UserName, TimeStamp, MessageText);
            return output;
        }
    }
}
