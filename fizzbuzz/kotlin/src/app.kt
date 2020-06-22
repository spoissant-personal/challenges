fun main() {
//    for(i in 1..100) {
//        var res = "${if(i%3===0) "Fizz" else ""}${if(i%5===0) "Buzz" else ""}"
//        println(if(res.isNotBlank()) res else i)
//    }

    (1..100).map { "${if(it%3===0) "Fizz" else ""}${if(it%5===0) "Buzz" else ""}".ifEmpty { it } }.forEach { println(it) }
}
