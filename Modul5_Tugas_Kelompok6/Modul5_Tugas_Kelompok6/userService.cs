using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_Kelompok6_CSharp
{
    class userService
    {
        private string[,] data, histories;
        private string email, password, roles, buku1, buku2, tanggal = "";

        public userService(string emails, string passwords)
        {
            email = emails;
            password = passwords;
            data = new string[2, 3] {
                {"kanyakelompok6@gmail.com", "12345", "superadmin" },
                {"alfinkelompok6@gmail.com", "12345", "user"  }
            };
            histories = new string[2, 4] {
                {"kanyakelompok6@gmail.com", "Fisika Dasar", "Dasar Komputer dan Pemprograman", "24-04-20" },
                {"alfinkelompok6@gmail.com", "Dasar Komputer dan Pemprograman", "Konsep Jaringan Komputer", "24-04-20"  }
            };
        }

        public void login()
        {
            var (status, role) = checkCredentials();
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
        public void pinjaman()
        {
            var (status, buku1) = checkBooks1();
            if (status == true)
            {
                Console.WriteLine("\n" + email + " Meminjam buku : \n" + buku1);
            }
        }
        public void waktu()
        {
            var (status, tanggal) = checkTime();
            if (status == true)
            {
                Console.WriteLine("Tanggal Peminjaman : " + tanggal);
            }

        }
        private (bool, string) checkCredentials()
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
        private (bool, string) checkBooks1()
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
        private (bool, string) checkTime()
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
