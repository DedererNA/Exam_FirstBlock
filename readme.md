# Описание программы
## Метод **GetSize**
1. Выводится сообщение пользователю с просьбой ввести размер списка;
2. Считывается введенная строка и преобразуется в переменную **size** типа int;
3. Возвращается переменная **size**.

***Примечание:** переменная **size** создается, чтобы использоваться в следующем методе.*
## Метод **GetArr**
Метод использует как параметр переменную **size** типа **int**.

1. Объявляется строковый массив **array** длины **size**;
2. При помощи цикла **for** массив заполняется строками, которые вводит пользователь;
3. Возвращается массив **array**.

Таким образом мы создаем исходный массив, с которым далее будут совершаться операции.
## Метод **ResArr**
Метод использует как параметр переменную **array** типа **string[]**.

1. Объявляется строковый массив **newarray** длинны массива **array** (соответствует переменной **size**);
2. Объявляется переменная **count** типа **int**. Эта переменная будет использоваться, чтобы опеределить длинну конечного списка и упростить его создание;
3. При помощи цикла **for** массив проверяется на наличие элементов с длиной меньше или равной 3. 
* Если такой элемент находится, он добавляется в массив **newarray** под индексом **count**, а счетчик **count** увеличивается на единицу;


*Таким образом, мы получаем новый массив, в котором находятся все элементы из исходного массива, а оставшиеся элементы равняются **null**.*

4. Объявляется новый строковый массив **result** длины **count**;
5. При помощи цикла **for** массив заполняется элементами из массива **newarray**, если индекс этих элементов меньше переменной **count**;
6. Возвращается массив **result**.
## Метод **Main**
1. Объявляется строковый массив **array** и заполняется при помощи методов **GetSize** и **GetArr**;
2. Массив **array** выводится пользователю;
3. Массив **array** преобразуется при помощи метода **ResArr** и выводится пользователю.