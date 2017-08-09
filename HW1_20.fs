let shuffle = function
    | [] -> []
    | xs -> let (first, second) = cut xs
            interleave (first, second);;