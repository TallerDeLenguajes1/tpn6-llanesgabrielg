# TP N° 6 

## Ejercicio 4


  - *¿String es una tipo por valor o un tipo por referencia?*
> **String** es un **tipo por referencia** que se almacenan siempre en el **heap**, y lo que se pasa a una función como parámetro no es una copia del dato, como en el caso de los tipos por valor, sino una **copia de la referencia al dato**.
> 
---

  - *¿Qué secuencias de escape tiene el tipo string?*
> ' - comilla simple
" - comillas dobles
\ - barra invertida
\0 - nulo
\a - alerta
\b - retroceso
\f - alimentación de formulario
\n - nueva línea
\r - retorno de carro
\t - pestaña horizontal
\v - pestaña vertical
\u - Secuencia de escape Unicode (UTF-16)
\U - Secuencia de escape Unicode (UTF-32)
\x - Secuencia de escape Unicode similar a "\u" excepto con longitud variable
>
---

  - *¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?*
> El carácter especial **@** sirve como un identificador literal. Se puede usar de las siguientes maneras:
1. Colocar @ antes de una cadena, sirve para interpretar literalmente el contenido de la cadena, es decir, si una cadena tiene @ antes de las comillas de apertura, la cadena se interpretará literalmente sin prestar atención a códigos de escape, saltos de línea, o cualquier otro símbolo que está contenga o hacer que éste interpretara de forma especial dichos símbolos.


``` c#
string filename1 = @"c:\documents\files\u0066.txt";
string filename2 = "c:\\documents\\files\\u0066.txt";

Console.WriteLine(filename1);
Console.WriteLine(filename2);
// The example displays the following output:
//     c:\documents\files\u0066.txt
//     c:\documents\files\u0066.txt
```
``` c#
string s1 = "He said, \"This is the last \u0063hance\x0021\"";
string s2 = @"He said, ""This is the last \u0063hance\x0021""";

Console.WriteLine(s1);
Console.WriteLine(s2);
// The example displays the following output:
//     He said, "This is the last chance!"
//     He said, "This is the last \u0063hance\x0021"
```
2. Para permitir que las palabras clave de C # se utilicen como identificadores.
``` c#
string[] @for = { "John", "James", "Joan", "Jamie" };
for (int ctr = 0; ctr < @for.Length; ctr++)
{
   Console.WriteLine($"Here is your gift, {@for[ctr]}!");
}
// The example displays the following output:
//     Here is your gift, John!
//     Here is your gift, James!
//     Here is your gift, Joan!
//     Here is your gift, Jamie!
```
---
