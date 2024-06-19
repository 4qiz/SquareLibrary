
<br />
<div align="center">

  <h2 align="center">SquareLibrary</h2>

  <p align="center">
    Библиотека для вычисления площали фигур
    <br />
  </p>
</div>

<!-- ABOUT THE PROJECT -->

## Стек

- C#
- .NET 8.0
- xUnit

<!-- USAGE EXAMPLES -->

## Использование

1 Инициалищируем объект GeometryCalculator

`GeometryCalculator calculator = new GeometryCalculator();`

2 Используем метод CalculateArea для вычисления площади

```
IShape rectangle = new Triangle(4,5,6); 
double area = calculator.CalculateArea(rectangle); // Вычисление площади треугольника

IShape cirle = new Circle(4);
double area = calculator.CalculateArea(cirle); // Вычисление площади круга
```

## Контакты

Antipin Egor - ispp.ea@gmail.com
