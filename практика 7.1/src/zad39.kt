import  kotlin.math.sqrt


fun main()
{
    println("Введите значения для 5 чисел, после каждого введенного числа нажимайте Enter.")
    val k = readLine()!!.toDouble()
    val b = readLine()!!.toDouble()
    val c = readLine()!!.toDouble()
    val d = readLine()!!.toDouble()
    val e = readLine()!!.toDouble()
    val a = c
    val b1 = d - k
    val c1 = e - b
    val discriminat = b1 * b1 - 4 * a * c1
        if (discriminat == 0.0)
        {
        val x = -b1 / (2 * a)
        val y = k * x + b
        val distance = sqrt(x * x + y * y)

        println("Точка пересечения ($x, $y), расстояние до начала координат $distance")
        }
    else if (discriminat > 0)
        {
        val x1 = (-b1 + sqrt(discriminat) / (2 * a))
        val y1 = k * x1 + b
        val distance1 = sqrt(x1 * x1 + y1 * y1)
        println("Первая точка пересечения ($x1, $y1), расстояние до начала координат $distance1")

        val x2 = (-b1 - sqrt(discriminat)) / (2 * a)
        val y2 = k * x2 + b
        val distance2 = sqrt(x2 * x2 + y2 * y2)
        println("Вторая точка пересечения ($x2, $y2), расстояние до начала координат $distance2")
        }
    else
    {
            println("Уравнения не пересекаются")

    }
}

