fun main ()
{
    try
    {
        println("Введите высоту прямоугольного отверстия: ")
        var a = readLine()!!.toInt()
        println("Введите ширину прямоугольного отверстия: ")
        var b = readLine()!!.toInt()
        println("Хорошо, высота отверстия = $a, а его ширина = $b")
        println("Теперь давайте зададим размеры кирпича, чтобы узнать пролезит он или нет")
        println("Какова его высота?")
        var x = readLine()!!.toInt()
        println("А ширина?")
        var y = readLine()!!.toInt()
        println("Толщина?")
        var z = readLine()!!.toInt()

        if (a > x && b > y)
        {
            println("Ваш кирпич спокойно пролазит, можете не переживать")

        }
        else
        {
            println("Увы, но ваш кирпич не пролезет, ищите другое отверстие.")

        }

    }
    catch (a:Exception)
    {
        println("error")

    }

}