using System;
using System.Collections.Generic;
using System.Text;

namespace MyExceptions
{
    class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("message sended by sms");
        }
    }
}
