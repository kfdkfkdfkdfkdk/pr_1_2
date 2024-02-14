fun main ()
{
    try
    {


        println("Введите значение для А: ")
        var a = readLine()!!.toInt()
        println("Введите значение для B: ")
        var b = readLine()!!.toInt()
        println("Введите значение для C: ")
        var c = readLine()!!.toInt()
        if (a in 1..3)
        {
            println("Ваше число = $a и оно попадает в диапозон от 1 до 3.")


        }
        if (b in 1..3)
        {
            println("Ваше число = $b и оно попадает в диапозон от 1 до 3.")

        }
        if (c in 1..3)
        {
            println("Ваше число = $c и оно попадает в диапозон от 1 до 3.")

        }
            else
            {
                println("Ваше число вне диапозона")
            }
    }
    catch (a:Exception)
    {
        println("Error")

    }

}