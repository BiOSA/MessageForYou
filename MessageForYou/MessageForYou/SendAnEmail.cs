using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MessageForYou
{
    class SendAnEmail
    {
        MailMessage msg;
        SmtpClient smtp;
        string name = "Сервис отправки уведомлений колледжа";
        string login = "messageforyou@bk.ru";
        string password = "P@ssw0rd!1";
        string smtpServer = "smtp.mail.ru";

        //Передаем в конструктор (почта получателя, тему письма, содержание письма, вложения)
        public void SendOneEmail(string mailTo, string title, string body, List <string> attachment)
        {
            msg = new MailMessage(name + " <" +login+"> ", mailTo);
            msg.Subject = title; //заголовок
            msg.Body = body; //тело
            msg.IsBodyHtml = true; //формат тела HTML
            for (int i = 0; i < attachment.Count; i++) //цикл для прикрепления файлов к письму
            {
                if (attachment != null & attachment[i] != "") //Если есть прикрепленные файлы и их путь корректен, заходим в цикл
                {
                    msg.Attachments.Add(new Attachment(attachment[i]));
                }
            }
            smtp = new SmtpClient(smtpServer, 25); //Испльзуем smtp.mail.ru и порт 25
            smtp.Credentials = new NetworkCredential(login, password); //Логин пароль почтового ящика "messageforyou@bk.ru
            smtp.EnableSsl = true; //Указываем что SMTP использует SSL шифрование
            smtp.Send(msg); //отправляем письмо
        }

        public void SendOneEmail(string mailTo, string title, string body) //Перегрузка метода. Отправка без вложения
        {
            msg = new MailMessage(name + " <" + login + "> ", mailTo);
            msg.Subject = title; //заголовок
            msg.Body = body; //тело
            msg.IsBodyHtml = true; //формат тела HTML
            smtp = new SmtpClient(smtpServer, 25); //Испльзуем smtp.mail.ru и порт 25
            smtp.Credentials = new NetworkCredential(login, password); //Логин пароль почтового ящика "messageforyou@bk.ru
            smtp.EnableSsl = true; //Указываем что SMTP использует SSL шифрование
            smtp.Send(msg); //отправляем письмо
        }

        public void MultiMessage(string mailTo, string title, string body, string attachment)
        {
            msg = new MailMessage(name + " <" + login + "> ", mailTo);
            msg.Subject = title; //заголовок
            msg.Body = body; //тело
            msg.IsBodyHtml = true; //формат тела HTML
            msg.Attachments.Add(new Attachment(attachment));
            smtp = new SmtpClient(smtpServer, 25); //Испльзуем smtp.mail.ru и порт 25
            smtp.Credentials = new NetworkCredential(login, password); //Логин пароль почтового ящика "messageforyou@bk.ru
            smtp.EnableSsl = true; //Указываем что SMTP использует SSL шифрование
            smtp.Send(msg); //отправляем письмо
        }
    }
}
