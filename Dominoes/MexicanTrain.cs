using System;

namespace Dominoes
{
	public class MexicanTrain : Train
	{
		public MexicanTrain() : base() { }
        public MexicanTrain(int engineValue) : base() { }
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
    }
}

