let rec cartesian = function
    | (xs, []) -> []
    | ([], ys) -> []
    | (x::xs, ys) -> List.map (fun y -> (x, y)) ys :: cartesian (xs, ys)