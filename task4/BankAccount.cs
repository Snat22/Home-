namespace task4;

public class BankAccount
{
    int _accountId;
    decimal _balance;
    public string OwnerName {get;set;}
    bool _isFrozen;
  
    public BankAccount(int accountid,decimal balance,string Ownername)
    {
        _accountId = accountid;
        _balance = balance;
      OwnerName = Ownername;
    }
    public void Deposit(decimal amount)
    {
        System.Console.WriteLine();
    }
    public void Withdraw(decimal amount)
    {
        System.Console.WriteLine(_balance);
    }
    public void FreezeAccount()
    {
          if(_isFrozen )

        System.Console.WriteLine(_isFrozen);
    }
    public void UnfreezeAccount()
    {
                  if(_isFrozen )

        System.Console.WriteLine(_isFrozen);
    }
}
