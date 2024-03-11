string[] array = { "Hello", "2", "world", ":-)" };
//int Length(string[] array);
int CountNewMassiv = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        {
        CountNewMassiv++;
        }
}
string [] ResArray = new string [CountNewMassiv];
int CountIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        {
        ResArray[CountIndex] = array[i];
        Console.WriteLine(ResArray[CountIndex]);
        CountIndex++;
        }
}
