namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quyidagi fieldlardan iborat Account klassini
            //encapsulation prinsipi asosida yarating: hisob raqami, ism familiyasi va balans.
            Account user1 = new("Jeck Ma");
            user1.HisobRaqam = 123456;
            user1.Balans = 12_000;
            user1.DesplayAccound();
            Console.WriteLine("____________");
            Account user2 = new("Brus Lee");
            user2.Balans = -99_3091;// shart tug'ri kelmasa typeni default quymati qaytariladi
            user2.HisobRaqam = 543210;
            user2.DesplayAccound();


        }
    }
    class Account
    {
        private int hisobRaqami;
        public string IsimFamilya { get; private set; }
        private decimal balans { get; set; }

        public decimal Balans
        {
            get
            {
                return balans;
            }
            set
            {
                if (value >= 0)
                {
                    balans = value;
                }
            }
        }
        public int HisobRaqam
        {
            get { return hisobRaqami; }
            set
            {
                if(value > 0 && value.ToString().Length >= 5)
                {
                    hisobRaqami = value;
                }
            }
        }
        public Account(string isimFamilya)
        {
            IsimFamilya = isimFamilya;

        }
        public void DesplayAccound()
        {
            Console.WriteLine($"Hisob raqami:{hisobRaqami}\nfull name:{IsimFamilya}\nBalans:{balans}");
        }
        
    }
}