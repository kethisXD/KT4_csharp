using FileKT4libary;

string path_file = @"C:\Users\xxx\projects\csharp\libary\KT4_main\text.txt";
FileKT my_file = new FileKT(path_file);


my_file.WriteFile("Hello from main");
my_file.ReadFile();