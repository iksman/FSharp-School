//


let DIVIDE = fun x y -> x / y
let MULTIP = fun x y -> x * y
let SUBT = fun x y -> x - y
let ADD = fun x y -> x + y
let MOD = fun x y -> x % y

let TRUE = fun x y -> x
let FALSE = fun x y -> y

let TUPLE<'a,'b> = fun (x:'a) (y:'b) -> fun f -> (f x) 
let SCHOOL = TUPLE<string, string>
let VECTOR2 = TUPLE<int,int>

let INL = fun x -> fun f g -> f x //is actually INL   ---->   Together forms Discriminated Union
let INR = fun y -> fun f g -> g y //is actually INR
let STUDENT = INL
let TEACHER = INR

let FST = fun f -> (f TRUE)
let SND = fun f -> (f FALSE)

let MATCH = fun u -> fun f g -> (u f) g //Breaks the union and executes one of two ways

let thing = fun f -> SCHOOL "Jan" "jan@mail.com" f
let thing2 = fun f -> SCHOOL "Griesmeel" "Gries@mail.com" f

let object = fun f ->
    if (f = 1) then
        TEACHER thing2
    else
        STUDENT thing


let result = MATCH (object 1) FST SND

[<EntryPoint>]
let main argv = 
    printfn "%A" (result)
    //printfn "%A" argv
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
