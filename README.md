# Задача по C#
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

-Юнит-тесты

-Легкость добавления других фигур

-Вычисление площади фигуры без знания типа фигуры в compile-time

-Проверку на то, является ли треугольник прямоугольным 

## Решение:
[Библиотека с фигурами](https://github.com/san017/MindBoxShapeTestTask/tree/master/MindBoxShapeLib)

[Unit тесты](https://github.com/san017/MindBoxShapeTestTask/tree/master/MindBoxUnitTest)

# Задание по SQL
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Для решения данной задачи, были созданы три таблицы: 

Products - продукты

Categories - категории 

Product_Category - связующая таблица продуктов и категории

![image](https://github.com/san017/MindBoxShapeTestTask/assets/93712965/c48e0e9e-a8ad-4ea4-9db6-432a0209916f)

Далее заполним таблицы некоторыми данными, представленные на скриншоте ниже.

![image](https://github.com/san017/MindBoxShapeTestTask/assets/93712965/aeba3808-6475-44de-b276-050d16b4aff7)

Теперь напишем запрос удовлетворяющий условию задачи.
~~~
SELECT p.Name, c.Name FROM Products p
LEFT JOIN Product_Category pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON c.Id = pc.CategoryId
ORDER BY p.Name
~~~
Результат запроса:

![image](https://github.com/san017/MindBoxShapeTestTask/assets/93712965/0c6f4103-8f4d-403a-9035-c7f5e3eee7dd)
