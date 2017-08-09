let rec interleave = function
    | ([],[]) -> []
    | ([], ys) -> ys
    | (xs, []) -> xs
    | (x::xs, y::ys) -> [x] @ [y] @ interleave (xs, ys);;