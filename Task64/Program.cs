//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
int Print(int index){
    switch(index){
        case 0: Console.Write($"Введите положительное значение для M: ");
        break;
        default: Console.Write($"Введите положительно значение для N: ");
        break;
    }
    while(true){
        string? answer = Console.ReadLine();
        bool isNumber = int.TryParse(answer, out int value);
        if (isNumber && value >= 0) return value;
        else if (value < 0) Console.Write($"Введено не число. Попробуйте снова: ");
        else Console.Write($"Введено не число. Попробуйте снова: ");
    }
}

void Start(){
    int[] answer = new int[2];
    for (int i = 0; i < 2; i++){
        answer[i] = Print(i);
    }
    Console.WriteLine($"{ShowNaturalNumbers(answer[0], answer[1])}");
}

int ShowNaturalNumbers(int m, int n){
    if (m == n) return m;
    else if(m <= 0 && n <= 0) {
        Console.WriteLine($"Между введёнными значениями {m} и {n} натуральных чисел не обнаружено.");
        return 0;
        }
    else if(m>n) {
        int temp = m;
        m = n;
        n = temp;
        return ShowNaturalNumbers(m, n);
    }
    else if (m > 0 && m < n) {
        Console.Write($"{m}\t");
        return ShowNaturalNumbers(++m, n);
    }
    else {
        return ShowNaturalNumbers(++m, n);
    }   
}
Start();