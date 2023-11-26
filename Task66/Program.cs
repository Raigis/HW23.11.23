//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
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
    Console.WriteLine($"Сумма всех натуральных чисел между введёнными значениями {answer[0]} и {answer[1]} = {SumNaturalNumbers(answer[0], answer[1])}");
}

int SumNaturalNumbers(int m, int n, int sum = 0){
    if(m <= 0 && n <= 0) return sum;
    else if (m > n) {
        int temp = m;
        m = n;
        n = temp;
        return SumNaturalNumbers(m, n);
    }
    else if (m > 0 && m < n) {
        sum += m++;
        return SumNaturalNumbers(m, n, sum);
    }
    else if (m <= 0){
        return SumNaturalNumbers(++m, n);
    }
    sum += m;
    return sum;
     
}
Start();