Console.WriteLine("Digite a sua placa:");
string placaCarro = Console.ReadLine();

string final= placaCarro.Substring(placaCarro.Length-1,1);

if( final == "1" || final == "2"){
    Console.WriteLine("so pode andar segunda");
} else if(final == "3" || final == "4"){
 Console.WriteLine("so pode andar terca");
}else if(final == "5" || final == "6"){
 Console.WriteLine("so pode andar quarta");
}
 else if(final =="7" || final == "8"){
 Console.WriteLine("so pode andar quinta");
 }
 else if(final == "9" || final == "0" ){
    Console.WriteLine("so pode andar sexta");
 }
 
