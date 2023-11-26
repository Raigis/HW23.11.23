//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Print(int index){
    switch(index){
        case 0: Console.Write($"Введите неотрицательное значение для M: ");
        break;
        case 1: Console.Write($"Введите неотрицательное значение для N: ");
        break;
    }
    while(true){
        string? answer = Console.ReadLine();
        bool isNumber = int.TryParse(answer, out int value);
        if (isNumber && value >= 0) return value;
        else if (value < 0) Console.Write($"Введено отрицательное число. Попробуйте снова: ");
        else Console.Write($"Введено не число. Попробуйте снова: ");
    }
}

void Start(){
    int[] answer = new int[2];
    for (int i = 0; i < 2; i++){
        answer[i] = Print(i);
    }
    Console.WriteLine($"Результат функции Аккермана со значениями {answer[0]} и {answer[1]} = {Ackermann(answer[0], answer[1])}");
}

int Ackermann(int m, int n){
    if (m == 0) return n+1;
    else if (n == 0) return Ackermann(m-1, n+1);
    else return Ackermann(m-1, Ackermann(m, n-1));
}
Start();