using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_Kelompok6_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, password;

            Console.Write("Email : ");
            email = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();

            userService data = new userService(email, password);
            data.login();
            data.pinjaman();
            data.waktu();


            Console.ReadKey();
        }
    }
}
