﻿using GenerikusPeldaProjekt;

string jegy1 = "5";
string jegy2 = "4";

Cserelo<string>.Csere(ref jegy1, ref jegy2);

Console.WriteLine(jegy1);
Console.WriteLine(jegy2);