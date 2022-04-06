using System;

namespace MyExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Send message by email\n2.Send message by sms\n3.Quit");
            int input = Convert.ToInt32(Console.ReadLine());
            SmsSender sms = new SmsSender();
            EmailSender email = new EmailSender();
            try
            {
                if (input <= 3 && input > 0)
                {
                    switch (input)
                    {
                        case 1:
                            email.SendMessage();
                            break;
                        case 2:
                            sms.SendMessage();
                            break;
                        case 3:
                            Console.WriteLine("Quit");
                            break;

                    }
                }
            }

            catch
            {
                throw new IndexOutOfRangeException("1 2 ve ya 3 daxil ede bilersiz ");
            }
        }
}
}