using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_Kelompok6_CSharp
{
    class UserService
    {
        private string[,] data, histories;
        private string email, password, roles, buku1, buku2, tanggal = "";

        public UserService(string emails, string passwords)
        {
            email = emails;
            password = passwords;
            data = new string[2, 3] {
                {"kanyakelompok06@gmail.com", "12345", "superadmin" },
                {"alfinkelompok06@gmail.com", "12345", "user"  }
            };
            histories = new string[2, 4] {
                {"kanyakelompok06@gmail.com", "Fisika Dasar", "Dasar Komputer dan Pemprograman", "24-04-20" },
                {"alfinkelompok06@gmail.com", "Dasar Komputer dan Pemprograman", "Konsep Jaringan Komputer", "24-04-20"  }
            };
        }

        public void Login()
        {
            var (status, role) = CheckCredentials();
            if (status == true)
            {
                Console.WriteLine("\nWelcome " + role);
                Console.WriteLine("Logged it as user email: " + email);
            }
            else
            {
                Console.WriteLine("\nInvalid Login");
            }
        }
        public void Pinjaman()
        {
            var (status, buku1) = CheckBooks1();
            if (status == true)
            {
                Console.WriteLine("\n" + email + " Meminjam buku : \n" + buku1);
            }
        }
        public void Pinjaman2()
        {
            var (status, buku2) = CheckBooks2();
            if (status == true)
            {
                Console.WriteLine(buku2);
            }
        }
        public void Waktu()
        {
            var (status, tanggal) = CheckTime();
            if (status == true)
            {
                Console.WriteLine("Tanggal Peminjaman : " + tanggal);
            }

        }
        private (bool, string) CheckCredentials()
        {
            for (int i = 0; i < histories.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    roles = data[i, 2];
                    return (true, roles);
                }
            }
            return (false, roles);
        }
        private (bool, string) CheckBooks1()
        {
            for (int i = 0; i < histories.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    buku1 = histories[i, 1];
                    return (true, buku1);
                }
            }
            return (false, buku1);
        }
        private (bool, string) CheckBooks2()
        {
            for (int i = 0; i < histories.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    buku2 = histories[i, 2];
                    return (true, buku2);
                }
            }
            return (false, buku2);
        }
        private (bool, string) CheckTime()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    tanggal = histories[i, 3];
                    return (true, tanggal);
                }
            }
            return (false, tanggal);
        }
    }
}
