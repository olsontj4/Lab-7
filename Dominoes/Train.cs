using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public abstract class Train : IEnumerable<Domino>
    {
        protected List<Domino> dominoes;
        protected int engineValue;
        public Train()
        {
            engineValue = 12;
            dominoes = new List<Domino>();
        }
        public Train(int engValue)
        {
            engineValue = engValue;
            dominoes = new List<Domino>();
        }
        public int Count
        {
            get
            { 
                return dominoes.Count;
            }
        }
        public int EngineValue
        {
            get
            {
                return engineValue;
            }
            set
            {
                engineValue = value;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return (dominoes.Count == 0);
            }
        }
        public Domino LastDomino
        {
            get
            {
                if (IsEmpty)
                {
                    return null;
                }
                else
                {
                    return dominoes[dominoes.Count - 1];
                }
            }
        }
        public int PlayableValue
        {
            get
            {
                if (IsEmpty)
                {
                    return engineValue;
                }
                else
                {
                    return LastDomino.Side2;
                }
            }
        }
        public Domino this[int index]
        {
            get
            {
                return dominoes[index];
            }
        }
        public void Add(Domino d)
        {
            dominoes.Add(d);
        }
        public abstract IsPlayable(Hand h, Domino d, out bool mustFlip);
        protected bool IsPlayable(Domino d, out bool mustFlip)
        {
            if (PlayableValue == d.Side1)
            {
                mustFlip = false;
                return true;
            }
            else if (PlayableValue == d.Side2)
            {
                mustFlip= true;
                return true;
            }
            else
            {
                mustFlip = false;
                return false;
            }
        }
        public void Play(Domino d, Hand h)
        {
            bool mustFlip;
            if (IsPlayable(h, d, out mustFlip))
            {
                if (mustFlip)
                {
                    d.Flip();
                }
                Add(d);
            }
            else
            {
                throw new Exception("Invalid move.")
            }
        }
        public override string ToString()
        {
            string output = "";
            foreach (Domino d in dominoes)
            {
                output += d.ToString() + "\t";
            }
            output += "\n";
            return output;
        }
        public abstract ForEach(Hand h);
    }
}
