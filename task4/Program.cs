using task4;

BankAccount Baccount = new BankAccount(1001,555.00m,"Jhon Doe");
Baccount.Deposit(1000.00m);
Baccount.Withdraw(200.00m);

Baccount.FreezeAccount();
Baccount.Deposit(500.00m);

Baccount.UnfreezeAccount();
Baccount.Deposit(500.00m);