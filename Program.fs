// For more information see https://aka.ms/fsharp-console-apps
open System

// ### Input/Output ### //

printfn "Hello from F#"
// print the input args:
let args = System.Environment.GetCommandLineArgs()
printfn "%A" args

// print an array with printfn:
let numbers = [|1; 2; 3|]
printfn "%A" numbers // %A means anything - will print: [|1; 2; 3|]

// print with System.Console
Console.WriteLine(numbers) // will print: System.Int32[]

// console input
printf "talk to me: "
let input = Console.ReadLine()
printfn "saying: %A" input



// ### Variables/immutables ### //

let theInt = 1
let theFloat = 1.
let theString = "texthere"
let theDouble: double = 2
theInt = 2 // variables are immutable by default and cannot be changed (this compares 1 to 2 and returns false)
theInt = 1 // variables are immutable by default and cannot be changed (this compares 1 to 1 and returns true)

// arrays let us specificy the size of the collection
let theArray = [|1.; 2; 3.9|]
theArray[1] // accessing the array by index
theArray[1] = 2.0 // comparing the number in the array to another number
theArray[1] <- 2.5 // arrays are also not immutable so we can change the value of an index

let theList = [1; 2; 3;]
theList[1] // accessing the list by index
theList[1] = 2 // comparing the number in the list to another number
//theList[1] <- 5 // lists are immutable so you cannot change the value of an item like with arrays

let oneToTenList = [1..10] // creating a list from 1-10
let oneToTenArray = [|1..10|] // creating an array from 1-10
let countingBackwards = [|10..-2..0|] // creating an array like: [|10; 8; 6; 4; 2; 0|]

// creating a new list from the old list and adding -1 at the start of it:
let newList = -1 :: theList
// extracting head and tail from a list (both theHead and theTail variables will be created):
let theHead :: theTail = theList
theHead
theTail
// concatenate/combine lists using the @ symbol between the lists to combine:
let combinedList = [-10..0] @ oneToTenList



// ### Functions ### //

// define a function that takes in one int x, multiplies it with itself and returns the value
// the last expression in the function will be the value returned
let square x = x * x
// calling the function does not use paranthesis for the inputs
let sumResult = square 5 

//function with multiple params
let sum numberOne numberTwo =
  // puts result in a variable
  let result = numberOne + numberTwo
  result // returns the result

// calling the function
let theSum = sum 1 2
// using "pipe forward" to call the function


let subtract numberOne numberTwo =
  let result = numberOne - numberTwo
  result

// this will make 10 the most right number into the function (the pipe points to the right?)
let pipedForward = 10 |> subtract 110
// creates a new function (110 |> subtract) where 110 is the first number - then the number 10 is piped to that new function
// (Partial Application concept)
let pipedPartialApplication = 10 |> (110 |> subtract)