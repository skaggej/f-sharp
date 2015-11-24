//// Learn more about F# at http://fsharp.net
//
//let x = 100;
//let mutable y = 1;
//
//#if INTERACTIVE
//let x = 100;
//#endif
//
//try  
//  #if INTERACTIVE 
//  Some(int32 x);
//  #else
//  System.Console.Write("Enter a number:  ");
//  let x = System.Console.Read();  
//  Some(int32(x));
//  #endif
//with
//  | :? System.FormatException -> 
//      printfn "Invalid Number!";
//      Some(0);
//
//while(y<x) do
//  y <- y+1
//  //If it's prime, print it out
//  if y%2 <> 0 then System.Console.WriteLine(y);
//
//System.Console.Write("\nPress any key to continue...");
//System.Console.ReadKey();


// Recursive isprime function.
let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

let aSequence = seq { for n in 1..100 do if isprime n then yield n }
for x in aSequence do
    printfn "%d" x
System.Console.WriteLine("Press Enter to exit...");
ignore(System.Console.ReadLine());