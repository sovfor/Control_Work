// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[]{"s","#4w","ffasfda","E-0", "Kazan", "33-"};
string[] arr = new string[array.Length];
int count = 0;
string str;
for(int i = 0; i < array.Length; i++){
str = array[i];
if(str.Length <= 3){
arr[count] = str;
count++;
}

}

for(int i = 0; i < arr.Length; i++){
    Console.Write(arr[i] + " ");
}