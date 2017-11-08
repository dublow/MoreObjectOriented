using System;

namespace Main.StatePattern
{
    interface IAccountState
    {
        IAccountState Deposit(Action addToBalance);
        IAccountState Withdraw(Action substractFrombalance);
        IAccountState Freeze();
        IAccountState HolderVerified();
        IAccountState Close();
    }
}
