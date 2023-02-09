module a2

// 2.1 time difference:
let timediff (h0, m0) (h1, m1) = 
    (h1*60 + m1)-(h0*60 + m0) //virker ikke hvis den går over midnat, lol

// 2.2 function minutes
let minutes = timediff(0,0) // timediff ved den skal have 2 arguments, så dem behøver vi ikek skrive
    // this gcould just as well have been let minutes (h,m) = h*60+m

// 2.3 / HR 2.2  - we are using some type inference
let rec pow =
    | ((text), 0) -> ""
    | ((text), n) -> text + dupn(text, n-1)

// 2.4 / HR 2.8
let rec bin = function          
    | (_, 0) -> 1
    | (a, b) when a = b -> 1
    | (a, b) ->  bin(a-1, b-1) + bin(a-1, b)


// let rec bin (a,b) = 
//     match (a,b) with
//     | (_, 0) -> 1
//     | (a, b) when a = b -> 1
//     | (a, b) ->  bin(a-1, b-1) + bin(a-1, b)

// let rec bin = function 
//     |(_,0) -> 1
//     |(a,b) -> if a=b then 1 else bin(a-1, b-1) + bin(a-1, b)

// let rec fact = function 
//     | 1 -> 1
//     | n -> n * fact(n-1)let bin (n, k) = 
//         (fact(n-1)/(fact(k-1)*(fact((n-1)-(k-1))))) + (fact(n-1)/(fact(k)*fact(n-1-k)))

// 2.5 / HR 2.9

(*
let rec f = function
| (0,y) -> y
| (x,y) -> f(x-1, x*y);;

1. Type of f: int * int -> int
2. the evaluation of f terminates for the y argument
3. Evaluation for f(2,3).
    f(2,3)
        f(2-1, 2*3)
        f(1, 6)
            f(1-1, 1*6)
            f(0, 6)
            6
        6
    6

    f(3,3)
        f(3-1, 3*3)
        f(2, 9)
            f(2-1, 2*9)
            f(1, 18)
                f(0, 18)
                18
            18
        18
    18
4. The mathematical meaning of f(x,y): x! * y
*)

// 2.6 / HR 2.10

// 2.7 / HR 2.13 Curry and Uncurry
let curry f x y = failwith "not implemented"

let uncurry g (x,y) = failwith "not implemented"

