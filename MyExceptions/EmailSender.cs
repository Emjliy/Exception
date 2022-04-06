using System;
using System.Collections.Generic;
using System.Text;

namespace MyExceptions
{
    class EmailSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("message sended by email");
        }
    }
}
