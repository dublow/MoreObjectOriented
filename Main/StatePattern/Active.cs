using System;

namespace Main.StatePattern
{
    class Active : IAccountState
    {
        private Action OnUnfreeze { get; }

        public Active(Action onUnfreeze)
        {
            OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Withdraw(Action substractFrombalance)
        {
            substractFrombalance();
            return this;
        }

        public IAccountState Freeze() => new Frozen(this.OnUnfreeze);

        public IAccountState HolderVerified() => this;

        public IAccountState Close() => new Closed();
    }
}
