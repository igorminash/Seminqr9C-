Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{GetAkkerman (m,n)}");

int GetAkkerman (int m, int n){
    if (m == 0) return n + 1;
    else{
        if (n == 0) return GetAkkerman(m-1,1);
        else{
            return GetAkkerman(m-1,GetAkkerman(m, n-1));
        }
    }
}