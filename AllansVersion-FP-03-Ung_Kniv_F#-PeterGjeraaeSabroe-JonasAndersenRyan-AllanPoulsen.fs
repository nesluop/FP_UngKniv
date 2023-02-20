module a2
// Exercise 3.1 downTo + downTo2
// let rec downTo n = failwith "not implemented"

let downTo n = 
    if n < 1
    then failwith "n must larger than 0"
    else [n .. -1 .. 1]

let downTo n = 
    if n < 1
    then failwith "n must larger than 0"
    else n::downTo(n-1)

// let rec downTo2 = failwith "not implemented"
let rec downTo2 n = 
    match n with
    | 0 -> []
    | n -> n :: downTo2(n-1)

let rec downTo2 n = 
    match n with
    | 0 -> []
    | n -> [n .. -1 .. 1]

// Exercise 3.2 removeOddIdx
// let rec removeOddIdx (xs: int list) = failwith "not implemented"
let rec removeOddIdx list = 
    match list with  
    | [] -> []          //<--- For some reason we do not get empty list. The idea is that if empty, return an emty list
    | [x] -> [x]        //If ther is only one element in the list then just return the list
    | x::y::xs -> x::removeOddIdx xs //Keep the first element x, discard the 2nd element y and recursively call the function


// Exercise 3.3 combinePair
// let rec combinePair (xs :int list) = failwith "not implemented"

let rec combinePair = function
    | x0::x1::(x2::_ as xs) -> (x0, x1) :: combinePair xs //<-- for some reason this omits the last pair.
    |_ -> []

// Exercise 3.4 - HR 3.2 - British currency

// Money tuple addition
// let (^+^) a b = failwith "not implemented"
let (^+^) (a, b, c) (d, e, f) = 
    let pence = (c + f) % 12
    let shilling = (b + e + (int (c + f) /12)) % 20
    let pound =  a + d + ((b + e + int (c + f) /12) / 20)
    (pound, shilling, pence)


// Money tuple subtraction
// let (^-^) a b = failwith "not implemented"

(*Den går nok lidt over åen efter vand. Skal lige checkes om den regner rigtigt*)
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
// let (|+|) a b = failwith "not implemented"
(*Jeg er slet ikke sikker på, hvad der egentlig spørges til her!
Men altså; here goes:*)
let (|+|)  a b c = {pound = a; shilling = b; pence = c}  

// Money record subtraction
let (|-|) a b = failwith "not implemented"
(*Har jeg ikke lige et godt bud på...*)


// Exercise 3.5 - HR 3.3 - Complex numbers

//      1. Declare infix for addition and multiplication
// let ( .+) (a:float,b:float) (c:float,d:float) = failwith "not implemented"
let ( .+) (a:float,b:float) (c:float,d:float) = (a + c, b + d)

// let ( .*) (a:float,b:float) (c:float,d:float) = failwith "not implemented"
let ( .*) (a:float,b:float) (c:float,d:float) = (a*c-b*d, b*c + a*d)

//      2. Declare infix for subtraction and division
// let ( .-) (a:float,b:float) (c:float,d:float) = failwith "not implemented"
let ( .-) (a:float,b:float) (c:float,d:float) = (a - c, b - d)


let ( ./) (a,b) (c,d) = failwith "not implemented"
//      3. Use 'let' expressions in division to avoid repeated evals
(*Skal lige efterprøves*)
let ( ./) (a,b) (c,d) = 
    let inv_c = c/(c*c + d*d)
    let inv_d = -d/(c*c + d*d)
    (a*inv_c-b*inv_d, b*inv_c+a*inv_d)


let ( ../) (a:float,b:float) (c:float,d:float) = failwith "not implemented"
//JEg forstår ikke spørgsmålet... 

// Exercise 3.6 - HR 4.4 - altSum -> HR page 76
// function alternating between adding and subtracting the contents of a list.
// let rec altsum = failwith "not implemented"
let rec altsum = function
    | [] -> 0
    | [x] -> x
    | x0::x1::xs -> x0-x1 + altsum xs