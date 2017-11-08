using System;

namespace Main.StatePattern
{
    class NotVerified : IAccountState
    {
        private Action OnUnfreeze { get; }

        public NotVerified(Action onUnfreeze)
        {
            OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Withdraw(Action substractFrombalance) => this;

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => new Active(this.OnUnfreeze);

        public IAccountState Close() => new Closed();
    }
}
