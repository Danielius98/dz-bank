using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(100.0); // Создание объекта банковского счета

        while (true)
        {
            Console.WriteLine("Введите сумму для снятия (для выхода введите 'exit'):");
            string input = Console.ReadLine(); // Чтение введенной пользователем суммы

            if (input.ToLower().Equals("exit"))
            {
                break;
            }

            try
            {
                double amount = Convert.ToDouble(input); // Преобразование введенной строки в число
                account.Withdraw(amount); // Вызов метода снятия средств
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода. Пожалуйста, введите число.");
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message); // Обработка исключения недостатка средств
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message); // Обработка других исключений
            }
        }
    }
}