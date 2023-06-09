# Итоговая проверочная работа.

### __Задача:__ Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

<br>

Примеры:

* ["Hello", "2", "world", ":-)"] > ["2", "5)"]
* ["1234", "1567", "-2", "computer science"] > ["-2"]
* ["Russia", "Denmark", "Kazan"] -> []

<br>

---

### __Решение:__ 

1. Просим пользователя ввести элементы массива.
2. Делаем проверку ввода с помощью метода ```IsEmptyArray```. Если пользоваетль ничего не ввел, с помощью рекурсии просим пользователя повторить ввод. Если данные были введены, записываем их в массив ```stringArray```.
3. С помощью метода ```FillArrary``` сначала определяем размер нового массива ```correctArray```. Проверяем размер элементов массива ```stringArray``` циклом ```foreach```, если они соответствуют условию (<= 3) увеличиваем счетчик ```count``` на 1. Счетичк будет выступать в качестве размера для нового массива.
4. Далее, с помощью цикла ```for``` попорядку перебераем элменты массива ```stringArray``` и присваиваем  массиву ```correctArray``` те элементы которые соответствуют условию (<= 3).
5. Выводим в коноль преобразованный массив ```correctArray```.

<br>

Блок-схема алгоритма:
![Блок-схема алгоритма](Final_HW_Diagram.jpg)