using System;
namespace Coursework
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    #region Subject
    abstract class Observer
    {
        public Observer()
        {
        }
        private List<string> _listOfFiles = new List<string>();;
        private List<IUser> _users = new List<IUser>();

        public void Attach(IUser user)
        {
            _users.Add(user);
        }

        public void Detach(IUser user)
        {
            _users.Remove(user);
        }

        public void Notify()
        {
            foreach (IUser user in _users)
            {
                user.Update(this);
            }

            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return _pricePerPound; }
            set
            {
                if (_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }
    }
    #endregion
}
