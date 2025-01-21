let x = ref 10
let y = ref 20
let z = ref 30

let swap (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d %d" !x !y !z