using System;

namespace Main.StatePattern
{
    class Frozen : IAccountState
    {
        private Action OnUnfreeze { get; }

        public Frozen(Action onUnfreeze)
        {
            OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            this.OnUnfreeze();
            addToBalance();
            return new Active(this.OnUnfreeze);
        }

        public IAccountState Withdraw(Action substractFrombalance)
        {
            this.OnUnfreeze();
            substractFrombalance();
            return new Active(this.OnUnfreeze);
        }

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => this;

        public IAccountState Close() => new Closed();
    }
}
