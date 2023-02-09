module a2

// 2.1 time difference:
let timediff (h0, m0) (h1, m1) = 
    (h1*60 + m1)-(h0*60 + m0) //virker ikke hvis den går over midnat, lol

// 2.2 function minutes
let minutes (h, m) = failwith "not implemented"

// 2.3 / HR 2.2
let rec pow (s,n) = failwith "not implemented"

// 2.4 / HR 2.8
let rec bin (a,b) = failwith "not implemented"

// 2.5 / HR 2.9

// 2.6 / HR 2.10

// 2.7 / HR 2.13 Curry and Uncurry
let curry f x y = failwith "not implemented"

let uncurry g (x,y) = failwith "not implemented"

