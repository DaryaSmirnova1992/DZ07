﻿int [] array = GetArray(8);
Console.WriteLine("[{0}]", string.Join(",",array));

int [] GetArray(int size)
{
        int [] result = new int [size];
        for(int i=0; i< size; i++)
        {
            result[i] = new Random().Next();
        }
        return result;
}
