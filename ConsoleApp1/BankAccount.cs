using System;

// Определение пользовательского исключения для случаев недостатка средств
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

// Класс для банковского счета
public class BankAccount
{
    private double balance; // Баланс счета

    // Конструктор, устанавливающий начальный баланс
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    // Метод для снятия средств
    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Сумма для снятия не может быть отрицательной.");
        }

        if (amount > balance)
        {
            throw new InsufficientFundsException("Недостаточно средств на счете для снятия указанной суммы.");
        }

        balance -= amount;
        Console.WriteLine($"Снято {amount} со счета. Остаток: {balance}");
    }
}