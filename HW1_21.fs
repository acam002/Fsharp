let rec countaux = function
    |(d,t) when d = t -> 0
    |(d,t) -> 1 + countaux (shuffle d, t)        

let countshuffles n =
    let t = [1..n]
    let d = shuffle t
    1 + countaux (d, t);;