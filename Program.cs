string [] formArrayWithElementsConstistingNoMoreThanThreeSymbols (string [] in_array){
    string [] out_array = new string [in_array.Length];
    int j = 0;
    for (int i = 0; i < in_array.Length; i++)
    {
        if (in_array[i].Length < 4)
        {
            out_array [j] = in_array[i];
            j++;
        }
    }
    return out_array;
}

void printArray(string[] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
             Console.Write("| "+array[i]+" |");
    
    }
    Console.WriteLine();
}

string [] in_array = {"hello", "2", "world", ":-)"};

string [] out_array = formArrayWithElementsConstistingNoMoreThanThreeSymbols (in_array);
printArray(in_array);
printArray(out_array);

