﻿using ClassString;
using TDate;

Console.WriteLine(TestandoString.StringReplace("Esse e um teste", "teste", "exemplo"));

int index = TestandoString.StringIndexOf("Esse e um teste", "teste");

Console.WriteLine(TestandoString.RemovePalavraPeloIndex("Esse e um teste", index, 5));

Console.WriteLine(TestandoString.StringContains("Esse e um teste", "teste"));

string[] words = {"Esse", "e", "um", "teste"};

Console.WriteLine(TestandoString.StringJoin(words));

string[] phase = TestandoString.StringSplit("Esse e um teste");

if(false)
{
    foreach(string word in phase)
    {
        Console.WriteLine(word.ToUpper());
    }
}

// interpolaçao de Strings

string rua = "Rua Vergueiro 3185";

int numero = 3185;

string cidade = "São Paulo";

string estado = "SP";

string Endereco = $"Endereço: {rua}, {numero}, {cidade}, {estado}";


// Datas em C#

// Date.Util();
Date.OnlyDate();
// Date.Now();