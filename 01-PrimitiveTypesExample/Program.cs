Console.WriteLine("-----   Primitive types in C#   -----");
Console.WriteLine("\n** byte & Sbyte **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of byte: " + byte.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of byte: " + default(byte));
Console.WriteLine("MV of sbyte: " + sbyte.MaxValue);
Console.WriteLine("DV of sbyte: " + default(sbyte));

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\n** short & ushort **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of short: " + short.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of short: " + default(short));
Console.WriteLine("MV of ushort: " + ushort.MaxValue);
Console.WriteLine("DV of ushort: " + default(ushort));

Console.WriteLine("\n-------------------------------------");

Console.WriteLine("\n** int & uint **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of int: " + int.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of int: " + default(int));
Console.WriteLine("MV of uint: " + uint.MaxValue);
Console.WriteLine("DV of uint: " + default(uint));

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\n** long & ulong **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of long: " + long.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of long: " + default(long));
Console.WriteLine("MV of uint: " + ulong.MaxValue);
Console.WriteLine("DV of uint: " + default(ulong));

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\n** decimal **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of decimal: " + decimal.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of decimal: " + default(decimal));

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\n** float **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of float: " + float.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of float: " + default(float));

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\n** double **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine("MV of double: " + double.MaxValue, Console.ForegroundColor = ConsoleColor.White);
Console.WriteLine("DV of double: " + default(double));

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("\n** char **", Console.ForegroundColor = ConsoleColor.Green);
Console.WriteLine('M');
Console.WriteLine("\n-------------------------------------");
Console.ReadKey();