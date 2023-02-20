module a2

// Exercise 3.1 downTo + downTo2
let downTo n = 
    if n < 1
    then failwith "n must larger than 0"
    else [n .. -1 .. 1]


let rec downTo2 n = 
    match n with
    | 0 -> []
    | n -> n :: downTo2(n-1)


// Exercise 3.2 removeOddIdx
let rec removeOddIdx (xs: int list) = 
    match xs with
    |x0::x1::xs -> x0::removeOddIdx(xs)
    |[x0] -> [x0]
    |[] -> []

// Exercise 3.3 combinePair
let rec combinePair (xs :int list) = 
    match xs with
    |x0::x1::xs -> (x0, x1)::combinePair(xs)
    |[x0] -> []
    |[] -> []



// Exercise 3.4 - HR 3.2 - British currency

// Money tuple addition
let (^+^) (a, b, c) (d, e, f) = 
    let pence = (c + f) % 12
    let shilling = (b + e + (int (c + f) /12)) % 20
    let pound =  a + d + ((b + e + int (c + f) /12) / 20)
    (pound, shilling, pence)

// Money tuple subtraction
let (^-^) (a, b, c) (d, e, f) = 
    let pence1 = a*20*12 + b*12 + c
    let pence2 = d*20*12 + e*12 + f
    let penceDiff = pence1-pence2
    let pound = int (penceDiff /(20*12))
    let shilling = int ((penceDiff - pound*20*12)/12)
    let pence = int (penceDiff - pound*20*12 - shilling * 12)
    (pound, shilling, pence)

type Money = {pound : int; shilling : int; pence : int};;
// Money record addition
let (|+|) a b = failwith "not implemented"

type Money = {pound : int; shilling : int; pence : int};;

let (^+^) (a, b, c) (d, e, f) = 
    let pe = (c + f) % 12
    let sh = ((b + e) + (int ((c + f)) /12)) % 20
    let po =  a + d + ((b + e + int ((c + f)) /12) / 20)
    {pound = po; shilling = sh; pence = pe}

// let (^-^) (a, b, c) (d, e, f) = 
//     let pence1 = a*20*12 + b*12 + c
//     let pence2 = d*20*12 + e*12 + f
//     let penceDiff = pence1-pence2
//     let po = int (penceDiff /(20*12))
//     let sh = int ((penceDiff - po*20*12)/12)
//     let pe = int (penceDiff - po*20*12 - sh * 12)
//     {pound = po; shilling  = sh; pence = pe}



let (|+|) moneyA moneyB =  
    let pe = (moneyA.pence + moneyB.pence) % 12
    let sh = ((moneyA.shilling + moneyB.shilling) + (int ((moneyA.pence + moneyB.pence)) /12)) % 20
    let po =  moneyA.pound + moneyB.pound + ((moneyA.shilling + moneyB.shilling + int ((moneyA.pence + moneyB.pence)) /12) / 20)
    {pound = po; shilling = sh; pence = pe}
    
let moneyA = {pound = 10; shilling = 4; pence = 7};;
let moneyB = {pound = 4; shilling = 13; pence = 5};;     



// Money record subtraction
let (|-|) a b = failwith "not implemented"

// Exercise 3.5 - HR 3.3 - Complex numbers

//      1. Declare infix for addition and multiplication
let ( .+) (a:float,b:float) (c:float,d:float) = failwith "not implemented"

let ( .*) (a:float,b:float) (c:float,d:float) = failwith "not implemented"

//      2. Declare infix for subtraction and division
let ( .-) (a:float,b:float) (c:float,d:float) = failwith "not implemented"

let ( ./) (a,b) (c,d) = failwith "not implemented"
//      3. Use 'let' expressions in division to avoid repeated evals
let ( ../) (a:float,b:float) (c:float,d:float) = failwith "not implemented"


// Exercise 3.6 - HR 4.4 - altSum -> HR page 76
// function alternating between adding and subtracting the contents of a list.
let rec altsum = failwith "not implemented"