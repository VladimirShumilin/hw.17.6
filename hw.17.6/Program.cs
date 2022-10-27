using hw._17._6.models;

// Обычный аккаунт 
BaseAccount baseAccount = new BaseAccount() { Balance = 110000 };
Calculator.CalculateInterest(baseAccount);


// Зарплатный аккаунт
SalaryAccount salaryAccount = new SalaryAccount() { Balance = 110000 };
Calculator.CalculateInterest(salaryAccount);


Console.ReadLine();