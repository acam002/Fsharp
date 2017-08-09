let rec powerset xs =
    match xs with
    | [] -> [[]]
    | (x::xs) -> 
      let pwr = powerset xs 
      List.map (fun xs' -> x::xs') pwr @ pwr