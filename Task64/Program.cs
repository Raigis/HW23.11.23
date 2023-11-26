//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
int Print(int index){
    switch(index){
        case 0: Console.Write($"Введите значение для M: ");
        break;
        default: Console.Write($"Введите значение для N: ");
        break;
    }
    while(true){
        string? answer = Console.ReadLine();
        bool isNumber = int.TryParse(answer, out int value);
        if (isNumber) return value;
        else Console.Write($"Введено не число. Попробуйте снова: ");
    }
}

void Start(){
    int[] answer = new int[2];
    for (int i = 0; i < 2; i++){
        answer[i] = Print(i);
    }
    ShowNaturalNumbers(answer[0], answer[1]);
}

void ShowNaturalNumbers(int m, int n){
    if(m <= 0 && n <= 0) Console.WriteLine($"Между введёнными значениями {m} и {n} натуральных чисел не обнаружено.");
    else if (m > 0 && m <= n) {
        Console.Write($"{m}\t");
        ShowNaturalNumbers(++m, n);
    }
    else if (m <= 0){
        ShowNaturalNumbers(++m, n);
    }
     
}
Start();