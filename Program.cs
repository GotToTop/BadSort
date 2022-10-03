Console.WriteLine("Hello, World! Sorting algorithm initialization...");

int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };
var maxVal = intArray.Max();
var rng = new Random();
for (int i = 0; i < intArray.Length; i++) { 
  intArray[i] = rng.Next(0, maxVal+1);
}
