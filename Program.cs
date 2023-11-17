Console.Write("Введите 1е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
int min;
//поиск MAX
if (a>b){
    max = a;
    }
else{
    max = b;
}
if (c>max){
    max = c;
}
// поиск MIN
if (a>b){
    min = b;
    }
else{
    min = a;
}
if (c<min){
    min = c;
}
if(a==b && b==c){
Console.Write($"Числа равны друг другу");    
}
else{
    Console.Write($"min = {min}, max = {max}");
}
