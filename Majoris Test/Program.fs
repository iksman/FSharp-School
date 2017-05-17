// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let T = fun x y -> x
let F = fun x y -> y

let TUPLE = fun x y -> fun f -> (f x) y

let STUDENT = fun x -> fun f g -> f x //is actually INL   ----> Together forms Discriminated Union
let TEACHER = fun y -> fun f g -> g y //is actually INR

let FST = fun f -> (f (fun x y -> x))
let SND = fun f -> (f (fun x y -> y))

let MATCH = fun u -> fun f g -> (u f) g //Breaks the union and executes one of two ways

let thing = fun f -> TUPLE "Jan" "jan@mail.com" f
let thing2 = fun f -> TUPLE "Griesmeel" "Gries@mail.com" f

let result = MATCH (TEACHER thing2) SND FST

[<EntryPoint>]
let main argv = 
    printfn "%A" (result)
    //printfn "%A" argv
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
