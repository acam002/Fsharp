let rec transpose xs =
  match xs with
  | h::hs ->
      match h with
      | v::vs ->
          let x = List.map List.head xs
          let rem = transpose (List.map List.tail xs)
          x::rem
      | _ -> []
  | _ -> []