using System;

namespace ATMSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            string myoptions;

            Console.WriteLine("Please insert your card");
            Console.WriteLine("I have recieved the card, please press ENTER to continue......");
            Console.ReadLine();
            Console.Write("...............................................................................");
            Console.WriteLine("....................................................");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Choose only the number---- 1. Check Balance, 2. Withdraw Cash, 3. Deposit Cash, 4. Eject Card");
            Console.Write(">> ");
            myoptions = Console.ReadLine();
            Console.Clear();
            switch (myoptions)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    WithdrawCash();
                    break;
                case "3":
                    CashDeposit();
                    break;
                case "4":
                    Eject();
                    break;
            }
            MainMenu();
        }
        static void MenuMenu()
        {
            string myoptions;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Choose only the number");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Eject Card");
            Console.Write(">> ");
            myoptions = Console.ReadLine();
            Console.Clear();
            switch (myoptions)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    WithdrawCash();
                    break;
                case "3":
                    CashDeposit();
                    break;
            }
            MainMenu();
        }
        static void CheckBalance()
        {
            string options1, options2, receipt; int pin;
            double balance;
            balance = 30000.00;
            Console.WriteLine("CHECK BALANCE");

            Console.WriteLine("SAVINGS");
            Console.WriteLine("Please enter your personal PIN");
            Console.WriteLine("Cover the keypad while typing...");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your current balance is: " + balance);
            Console.Write("How would you like to view your balance? Print[p] / Exit[x]: ");
            receipt = Console.ReadLine();
            Console.Clear();
            if (receipt == "p" || receipt == "P")
            {
                Console.WriteLine("Thank you for trusting BPO. Please take your receipt.");
                Console.Write("...............................................................................");
                Console.WriteLine("....................................................");
                Console.Write("Do another transaction? [Y/N]: ");
                options1 = Console.ReadLine();
                Console.Clear();
                if (options1 == "y" || options1 == "Y")
                {
                    MenuMenu();
                }

                else
                {
                    Console.Write("Card ejected.");
                    Environment.Exit(0);
                }
            }
            else if (receipt == "x" || receipt == "x")
            {
                Console.Write("Do another transaction? [Y/N]: ");
                options2 = Console.ReadLine();
                Console.Clear();
                if (options2 == "Y" || options2 == "y")
                {
                    MenuMenu();
                }
                else
                {
                    Console.Write("Card ejected.");
                    Environment.Exit(0);
                }
            }

        }
        static void WithdrawCash()
        {
            string receipt, receipt1; int pin;
            double balance, withdraw;
            balance = 30000.00;
            Console.WriteLine("WIDTHRAW CASH");
            Console.WriteLine("SAVINGS");
            Console.WriteLine("Please enter your personal PIN");
            Console.WriteLine("Cover the keypad while typing...");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your current balance is: P" + balance);
            Console.Write("Enter the amount you want to deposit: P");
            withdraw = Convert.ToDouble(Console.ReadLine());
            balance -= withdraw;
            Console.WriteLine("Current balance is: P" + balance);
            Console.Write("How would you like to view your balance? Print[p] / Exit[x]: ");
            receipt = Console.ReadLine();
            Console.Clear();
            if (receipt == "p" || receipt == "P")
            {
                Console.WriteLine("Thank you for trusting BPO. Please take your receipt.");
                Console.Write("...............................................................................");
                Console.WriteLine("....................................................");
                Console.Write("Do another transaction? [Y/N]: ");
                receipt1 = Console.ReadLine();
                Console.Clear();
                if (receipt1 == "y" || receipt1 == "Y")
                {
                    MenuMenu();
                }

                else
                {
                    Console.Write("Card ejected.");
                    Environment.Exit(0);
                }
            }
            else if (receipt == "x" || receipt == "X")
            {
                Console.Write("Do another transaction? [Y/N]: ");
                receipt = Console.ReadLine();
                Console.Clear();
                if (receipt == "Y" || receipt == "y")
                {
                    MenuMenu();
                }
                else
                {
                    Console.Write("Card ejected.");
                    Environment.Exit(0);
                }
            }
        }
        static void CashDeposit()
        {
            string options2, options3, receipt; int pin;
            double balance, deposit;
            balance = 30000.00;

            Console.WriteLine("CASH DEPOSIT");
            Console.WriteLine("SAVINGS");
            Console.WriteLine("Please enter your personal PIN");
            Console.WriteLine("Cover the keypad while typing...");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your current balance is: P" + balance);
            Console.Write("Enter the amount you want to deposit: P");
            deposit = Convert.ToDouble(Console.ReadLine());
            balance += deposit;
            Console.WriteLine("Current balance is: P" + balance);
            Console.Write("How would you like to view your balance? Print[p] / Exit[x]: ");
            receipt = Console.ReadLine();
            Console.Clear();
            if (receipt == "p" || receipt == "P")
            {
                Console.WriteLine("Thank you for trusting BPO. Please take your receipt.");
                Console.Write("...............................................................................");
                Console.WriteLine("....................................................");
                Console.Write("Do another transaction? [Y/N]: ");
                options2 = Console.ReadLine();
                Console.Clear();
                if (options2 == "y" || options2 == "Y")
                {
                    MenuMenu();
                }

                else
                {
                    Console.Write("Card ejected.");
                    Environment.Exit(0);
                }
            }
            else if (receipt == "x" || receipt == "X")
            {
                Console.Write("Do another transaction? [Y/N]: ");
                options3 = Console.ReadLine();
                Console.Clear();
                if (options3 == "Y" || options3 == "y")
                {
                    MenuMenu();
                }
                else
                {
                    Console.Write("Card ejected.");
                    Environment.Exit(0);
                }
            }
        }
        static void Eject()
        {
            Console.Write("Card ejected.");
            Environment.Exit(0);
        }
    }
}