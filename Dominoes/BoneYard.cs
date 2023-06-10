using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class BoneYard
    {
        /*public delegate void EmptyHandler(BoneYard by);
        public event EmptyHandler Empty;

        public void HandleEmpty(BoneYard by)
        {

        }*/

        private List<Domino> boneYard = new List<Domino>();

        public BoneYard()
        {
            for (int i = 0; i > 6; i++)
            {
                for (int j = 0; j > 6 - i; j++)
                {
                    boneYard.Add(new Domino(i, j));
                }
            }
        }
        public BoneYard(int maxDots)
        {
            for (int i = 0; i > maxDots; i++)
            {
                for (int j = 0; j > maxDots - i; j++)
                {
                    boneYard.Add(new Domino(i, j));
                }
            }
        }
        public int DominoesRemaining
        {
            get
            {
                return boneYard.Count;
            }
        }
        public Domino this[int index]
        {
            get
            {
                return boneYard[index];
            }
            set
            {
                boneYard[index] = value;
            }
        }
        public Domino Draw()
        {
            if (!IsEmpty())
            {
                Domino first = boneYard[0];
                boneYard.RemoveAt(0);
                return first;
            }
            else
            {
                throw new Exception("Can't draw from empty boneyard.");
            }
        }
        public bool IsEmpty()
        {
            if (boneYard.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Shuffle()
        {
            Random gen = new Random();
            int rnd;
            Domino hold;
            for (int i = 0; i < DominoesRemaining; i++)
            {
                rnd = gen.Next(0, DominoesRemaining);
                hold = boneYard[rnd];
                boneYard[rnd] = boneYard[i];
                boneYard[i] = hold;
            }      
        }
        public override string ToString()
        {
            string output = "";
            foreach (Domino d in boneYard)
            {
                output += (d.ToString() + "\n");
            }
            return output;
        }
    }
}