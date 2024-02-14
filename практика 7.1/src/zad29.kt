fun main ()
{
    println("Введите год: ")
    val year = readLine()!!.toInt()

    val vesokos = when
    {
        (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) -> true

        else -> false
    }
    if (vesokos)
    {
        println("$year - является високосным годом")
    }
    else {
        println("$year - не является високосным")

    }


}