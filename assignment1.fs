module a1
// 1.1
let sqr n = n*n
// 1.2
let pow a b = System.Math.Pow(a,b)

// 1.3 / HR 1.1
let g n = n+4

// 1.4 / HR 1.2
let h(x:float, y:float) = System.Math.Sqrt((x**2.0+y**2.0))

// 1.5 / HR 1.4
let rec f = function
    | 0 -> 0
    | n -> n + f(n-1)

(*
    f 4
    4 + f(4-1)
    4 + f(3)
    4 + 3 + f(3-1)
    4 + 3 + f(2)
    4 + 3 + 2 + f(2-1)
    4 + 3 + 2 + f(1)
    4 + 3 + 2 + 1 + f(1-1)
    4 + 3 + 2 + 1 + f(0)
    4 + 3 + 2 + 1 + 0
    4 + 3 + 2 + 1
    4 + 3 + 3
    4 + 6
    10
*)

// 1.6 / HR 1.5
let rec fib = function
    | 0 -> 0
    | 1 -> 1
    | n -> fib(n-1) + fib(n-2)

(*
    fib 4
    fib(4-1) + fib(4-2)
    fib(3) + fib(2)
    fib(3-1) + fib(3-2) + fib(2-1) + fib(2-2)
    fib(2) + fib(1) + fib(1) + fib(0)
    fib(2-1) + fib(2-2) + 1 + 1 + 0
    fib(1) + fib(0) + 1 + 1 + 0
    1 + 0 + 1 + 1 + 0
    1 + 1 + 1
    3
*)

// 1.7 / HR 1.6
let rec sum = function
    | (m,0) -> m
    | (m,n) -> m + n + sum(m,(n-1))

(*
    Recursion formula
    for integers m ≥ 0 and n ≥ 0
    a(m,0) = m
    a(m,n) = m + n + a(m,n-1)
*)

// 1.8 / HR 1.7

// 1.9 / HR 1.8

// 1.10 Duplicate strings: dup:string -> string
let dup a:string = failwith "not implemented"

// 1.11 Duplicate string n times.
let rec dupn (text:string) n = failwith "not implemented"

