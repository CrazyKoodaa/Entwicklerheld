using System;
using System.Collections.Generic;
using System.Linq;

namespace ChristmasBoxesImplementation
{
    public static class ChristmasBoxService
    {
        public static IEnumerable<ChristmasBox> GetShuffledPresentList(this List<ChristmasBox> boxList)
        {
            Comparer compare = new Comparer();
            Console.WriteLine($"\n\n\nNumbers to check = {boxList.Count}");

            // Copy List to a temp List
            List<ChristmasBox> tempBox = boxList.ToList();

            // Sort the Temp List descending
            tempBox.Sort(compare);

            // Rewrite the original List with the criteria bellow
            for (int i = 0; i < boxList.Count; i++)
            {
                // If the rest of (i+1)%4 is 2, then it's the 2nd, or 5th, etc. position 
                if ((i + 1) % 4 == 2)
                {
                    // take the biggest number which is in the tempBox on place 0 and delete 
                    // the biggest number in temp. Therefore the 2nd biggest number will take
                    // place 0;
                    boxList[i] = tempBox[0];
                    tempBox.RemoveAt(0);
                }
                else
                {
                    // take the smallest number from temp, and delete the smallest number from temp
                    int countingTempBox = tempBox.Count - 1;
                    boxList[i] = tempBox[countingTempBox];
                    tempBox.RemoveAt(countingTempBox);
                }
            }
            return boxList;
        }
    }
    // just a class Comparer which takes the Interface Comparer to Sort the type ChristmasBox
    class Comparer : IComparer<ChristmasBox>
    {
        // in a descending order
        public int Compare(ChristmasBox x, ChristmasBox y)
        {
            if (x.Weight > y.Weight) return -1;
            else if (x.Weight < y.Weight) return 1;
            else return 0;
        }
    }
}