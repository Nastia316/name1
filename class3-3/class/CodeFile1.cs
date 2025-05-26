int ar = Convert.ToInt32(Console.ReadLine());
int ai = Convert.ToInt32(Console.ReadLine());
int br = Convert.ToInt32(Console.ReadLine());
int bi = Convert.ToInt32(Console.ReadLine());
Compl a = new Compl(ar, ai);
Compl b = new Compl(br, bi);


//tatic void Main()
//{

//Console.WriteLine(a.Re);
//Console.WriteLine(a.Compl_Sum2(b).Re);
a.print(a+b);
a.print(a * b);
a.print(a / b);
//}


