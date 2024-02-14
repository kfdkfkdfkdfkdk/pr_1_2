fun main()
{
    try {
        println("Введите значение для числа A: ")
        var a = readLine()!!.toInt()
        println("Введите значение для числа B: ")
        var b = readLine()!!.toInt()
        println("Введите значение для числа C: ")
        var c = readLine()!!.toInt()
        println("Теперь запишим их в порядке убывания.")
        if (a > b && a > c && b > c)
        {
            println("Вот в порядке убывания: $a, $b, $c")
        }
        if (b > a && b > c && a > c)
        {
            println("Вот в порядке убывания: $b, $a, $c")
        }
        if (c > b && c > a && b > a)
        {
            println("Вот в порядке убывания: $c, $b, $a")
        }
        if (a > b && c> b && a > c)
        {
            println("Вот в порядке убывания: $a, $c, $b")
        }


        if (c > a && a > b && c > b)
        {
            println("Вот в порядке убывания: $c, $a, $b")
        }


    }
    catch (a:Exception)
    {
        println("Error")
    }

}