using System;
using RegistrationAccount;

namespace ManageUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            Registration registration = new Registration("mysql60.hostland.ru", "host1323541_itstep35", "host1323541_itstep", "269f43dc");
            
            registration.InsertNewItemInDate("jump-rostov@mail.ru", "anton2781618");
        }
    }
}