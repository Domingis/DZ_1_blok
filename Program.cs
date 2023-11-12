string[] startArray = new string[4]{"Heo", "2", "world", ":-)"};

string[] FilterArray(string[] array){
    string[] tempArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <=3){
            tempArray[j] = array[i];
            j++;
        }
    }
    string[] resultArray = new string[j];
    for (int i = 0; i < j; i++){
        resultArray[i] = tempArray[i];
    }
    return resultArray;
}

void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++){
        System.Console.Write(array[i] + " ");
    }
}

PrintArray(FilterArray(startArray));