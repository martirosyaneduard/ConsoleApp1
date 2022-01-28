using System;
using System.Collections.Generic;
using ConsoleApp1.Animals;

namespace ConsoleApp1.Cages
{
    class CageOfLions : Cage
    {
        EventDelegate myEvent = null;
        public event EventDelegate MyEvent
        {
            add
            {
                //stex mtacum em stugum dnem ete aryuce satkac chi nor avelacni,bayc chi linum, FollowEvent i mej erevi piti dnem stugume
                myEvent += value;
            }
            remove
            {
                myEvent -= value;
            }
        }
        public List<Lion> Lions { get; set; }
        public CageOfLions()
        {
            this.Lions = new List<Lion>();
        }
        public CageOfLions(int length, int width, int height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Lions = new List<Lion>();
        }
        public void InvokeEvent()//dure bacvec kere drvec vandaki mej u Event piti ashxati...hima chgitem vonc asem vor kere drvec vandaki mej vor sax aryucnere tenan u Event e call anem
        {
            OpenOrCloseDoor = true;
            Door();

            myEvent.Invoke();
        }
        public void FollowEvent()
        {
            for (int i = 0; i < Lions.Count; i++)
            {
                if (!Lions[i].AliveOrNot())
                {
                    MyEvent += new EventDelegate(Lions[i].Run);
                }
            }
        }
    }
}
