let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let z = add x y // Correct: Assign the return value to z

printf "%d" z