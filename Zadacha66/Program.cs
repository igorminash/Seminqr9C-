Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(M,N));


int PrintNumbers(int start, int end){
    if(start == end) return start;
    return(start + PrintNumbers(start + 1, end));
}
