using System;
namespace ArrayFindIndexCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myNames = 
            {
                "Michael", "Rhey", "Daniell", "Owen"
            }; 
            int index = Array.FindIndex(myNames, myNames => myNames.Equals("Daniell"));
            Console.WriteLine($"The index of Daniell: {index}");

            //We are creating a new array here
            //Since we are just removing a single element from the original array
            //We can say that the newArray.Length is 1 lesser than the oldArray.Length
            
            string[] updatedNames = new string[myNames.Length - 1];

            //if the element that we are excluding or removing to be included in the newArray is NOT at the index 0, we must copy the preceding elements
            //before the index of the excluded element
            //also the elements after the excluded element
            //otherwise, we don't need to copy preceding and elements after since the index that has been excluded is located at the index 0
            //we can already copy the elements from index 1 up to the last element
            if (index > 0) 
            {
                //since we have index 2 as excluded, we need to copy 2 elements on the preceding part
                //element at index 0 and index 1
                //Array.Copy(Array sourceArray, int sourceStartIndex, Array destinationArray, int destinationStartIndex, int numberOfElementsToCopyFromSourceArray)

                Array.Copy(myNames, 0, updatedNames, 0, index);

                //After copying Michael, Rhey. We need to copy Owen
                //sourceArray: myNames
                //sourceStartIndex: index + 1 (2 + 1) (3)
                //Note that in the sourceArray, Owen is at index 3
                //destinationArray: updatedNames
                //destinationStartIndex: currently, we have 2 elements, "Michael", "Rhey"
                //the index after it will be index 2
                //Owen should take the index 2 at the destinationArray
                //destinationStartIndex: index (2), Owen should take the position of the excluded element (Daniell)
                //numberOfElementsToCopyFromSourceArray: we know that Owen is the last/remaining element
                //from the sourceArray, we have 4 elements, we will remove/exclude 1, making it 3
                //however, we have already copied 2 on the preceding, subtracting 2 from 3, will be 1
                //indexOfExcludedElement is EQUAL to the number of copied preceding elements
                //numberOfElementsExcluded
                //numberOfElementsToCopyFromSourceArray: oldArray.Length - indexOfExcludedElement - numberOfElementsExcluded
                Array.Copy(myNames, index + 1, updatedNames, index, myNames.Length - index - 1);
            }
            Console.WriteLine();
            foreach(string name in updatedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}