void CubicResult(int num){
    Console.Write($"{num} -> ");
    for (int i = 1; i < num; i++){
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine(Math.Pow(num, 3) + ".");
}

int GetNumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int digit = GetNumber("please, insert a number: ");
CubicResult(digit);