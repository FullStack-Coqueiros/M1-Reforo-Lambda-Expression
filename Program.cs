Console.WriteLine(RetornaNumero(5));
Func<int, double> RetornaNumFunc = new Func<int, double>(num1 => num1+1.5);
Console.WriteLine(RetornaNumFunc(5));



double RetornaNumero(int num1){
  return num1+1.5;
}


//int RetornaNumero(int num1) => num1+1;
