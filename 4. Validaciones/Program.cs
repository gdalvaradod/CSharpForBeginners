// Validaciones o Condiciones
// If statements

/*
Sentencias más utilizadas
a < b - Menor que
a > b - Mayor que
a <= b - Menor que o igual
a >= b - Mayor que o igual
a == b - Igual
a != b - Diferente de

Condiciones
if
else
else if
*/

// Declaración de variables
int edad = 16;
string password = "Dante2023!!!!!!";
string passwordOld = "Dante2023!";

if(edad >= 18){
    Console.WriteLine("Puede tener licencia para conducir");
}
else{
    Console.WriteLine("Es menor de edad");
}

if(password == "Joshua2023!"){
    Console.WriteLine("Password aceptado");
}
else if(password == passwordOld){
    Console.WriteLine("Estás utilizando un password anterior");
}
else{
    Console.WriteLine("La contraseña es incorrecta");
}
