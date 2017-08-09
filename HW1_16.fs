let (.+) (a, b) (c, d) = 
    let common = gcd (b, d)
    let numerator = (a * d + c * d) / common
    let denominator = b * d / common
    let reduce = gcd(numerator, denominator)      
    (numerator/reduce, denominator / reduce);;

let (.*) (a, b) (c, d) =
    let numerator = a * c
    let denominator = b * d
    let reduce = gcd(numerator, denominator)
    (numerator/reduce, denominator / reduce);; 