let rec gencut = function
    | (0, xs) -> ([], xs)
    | (n, []) -> ([], [])
    | (n, x::xs) -> 
        let (left, right) = gencut(n - 1, xs)
        (x::left, right)

let cut = function
    |[] -> ([],[])
    |xs ->
        let half = List.length xs / 2
        gencut (half, xs);;