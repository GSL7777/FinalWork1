Console.WriteLine("Введите количество анализируемых данных:");
int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте минимальное количество символов:");
// int m = Convert.ToInt32(Console.ReadLine());
int m = 3;
string y = "Change";
int count = 0;

string [] array = new string [n];  
for (int i = 0; i < array.Length; i++)
{  
   Console.WriteLine("Введите данные:"); 
   string data = Convert.ToString(Console.ReadLine());
   if (data.Length > m)
   {
   array [i] = y; 
   count++;  
   }
   else array [i] = data;
} 

int k = n - count;
string [] newArray = new string[k]; 
int j = 0;
for (int i = 0; i < array.Length; i++)
{    
   if (array[i] != y)
   {
   newArray [j] = array[i];
   j++;  
   }
}

Console.WriteLine();
// Console.WriteLine($"[{string.Join(", ",array)}]"); 
Console.WriteLine($"[{string.Join(", ",newArray)}]");