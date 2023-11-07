// miche_kh @ lasallecollege

Console.WriteLine("Hello, Arrays!");

//int someVariable; 

//float temperature; // declaration reserve space in memory for a variable of type float ie 4bytes, there is no value
//temperature = 20;.5f // assignment

//float temperature1 = 18.5f; // decalaration and initialization

//Console.WriteLine($"temperature = {temperature} ");
//Console.WriteLine($"temperature1 = {temperature1} ");

float[] midtermGrades; // reserving 4b or 8bytes on the stack to hold a memory address for an array
Console.WriteLine(midtermGrades);

midtermGrades = new float[25]; // new float[25] constructs an array that accepts 25 float values 


//// declaration of an array

//float[] temperatureArray0 = { 18.5f, 17.5f, 30.2f, 14.5f, 0 }; // the size of the array will be determined by the number of values between {} and the array gets initialized with the values directly

//float[] temperatureArray; // this reserves a space of 4bytes (on a 32bit machine) and 8bytes (on a 64bit machine) to hold a memory address
//temperatureArray = new float[5]; // this finds 5*4bytes = 20bytes in memory, reserves that space, and returns the memory address of the first element and assigns it to temperatureArray

////Console.WriteLine(someVariable);

//Console.WriteLine("Once an array object is instantiated, the values in it are default values: "); 
//for (int i=0; i< temperatureArray.Length; i++)
//{
//    Console.WriteLine(temperatureArray[i]);
//}

//Console.WriteLine("temperatureArray holds " + temperatureArray.Length); // how many elements are in this array


//float[] temperatureArray1 = new float[5]; // this array is empty.

//temperatureArray1[0] = 10.5f;
//temperatureArray1[1] = 12.5f;
//temperatureArray1[2] = 14.5f;
//temperatureArray1[3] = 16.5f;
//temperatureArray1[4] = 18.5f;

//Console.WriteLine($"temperatureArray[0] = {temperatureArray1[0]} ");
//Console.WriteLine($"temperatureArray[1] = {temperatureArray1[1]} ");
//Console.WriteLine($"temperatureArray[2] = {temperatureArray1[2]} ");
//Console.WriteLine($"temperatureArray[3] = {temperatureArray1[3]} ");
//Console.WriteLine($"temperatureArray[4] = {temperatureArray1[4]} ");

////for (int i = 0; i <= temperatureArray1.Length-1; i++)
//for (int i=0; i<temperatureArray1.Length; i++) // i traverses index 0 to index 4
//{
//    Console.WriteLine("temperatureArray1 at index " + i + "= " + temperatureArray1[i]);
//}

//for (int i = 0; i < temperatureArray1.Length; i++)
//{
//    temperatureArray1[i] = temperatureArray1[i] + 2; 
//}

//Console.WriteLine(temperatureArray1.Length);

//foreach (int i in temperatureArray1)
//{
//    Console.Write(i);
//    i = i + 1;
//    Console.Write(i);
//}

//for (int i=0; i< temperatureArray1.Length; i++)
//{
//    Console.WriteLine(temperatureArray1[i]);
//}

//void swap(int a, int b)
//{
//    int c = a;  
//    a = b;
//    b = c;
    
//}

//int[] id = { 1, 9, 9, 8, 0, 0, 7, 1, 7}; // replace these digits with your school ID 
//int n = id.Length; // let n be the size of the array

//// algorithm A

//for (int i = 0; i < n - 1; i++)
//{
//    for (int j = 0; j < n - i - 1; j++)
//    {
//        if (id[j] > id[j + 1])
//            swap(id[j], id[j + 1]);
//    }
//}

//// before tracing the next algorithm, reset the array to your Id.
//// algorithm B

//for (int i = 0; i < n - 1; i++)
//{
//    int min_idx = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (id[j] < id[min_idx])
//            min_idx = j;
//    }
//    swap(id[min_idx], id[i]);
//}
//int a = 4_500_000; 
