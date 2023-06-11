using System;

namespace Dominoes
{
	public class PlayerTrain : Train
	{
		private Hand hand;
		private bool isOpen;
		public bool IsOpen { get { return isOpen; } }
		public PlayerTrain(Hand h) : base()
		{

		}
        public PlayerTrain(Hand h, int engineValue) : base()
        {

        }
		public bool IsPlayable(Hand h, Domino d, out bool mustFlip)
		{
            if (PlayableValue == d.Side1)
            {
                mustFlip = false;
                return true;
            }
            else if (PlayableValue == d.Side2)
            {
                mustFlip = true;
                return true;
            }
            else
            {
                mustFlip = false;
                return false;
            }
        }
		public void Open(bool isOpen)
		{
			this.isOpen = true;
		}
        public void Close(bool isOpen)
        {
            this.isOpen = false;
        }
    }
}

