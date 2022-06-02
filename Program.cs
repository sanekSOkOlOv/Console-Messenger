using System;

namespace ConsoleMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message ms = new Message();
            string output = JsonConvert.SerializeObject(ms);
            Message deserializedMs = JsonConvert.DeserializeObject<Message>(output);

            Console.WriteLine(output);
            Console.WriteLine(deserializedMs.ToString());

            //{ "UserName":"System","MessageText":"Online","TimeStamp":"2022-06-02T12:21:54.219595+03:00"}
            //System < 02.06.2022 12:21:54 > : Online
        }
    }
}
}
