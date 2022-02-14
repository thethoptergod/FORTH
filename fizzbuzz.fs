: fizz 3 mod 0 = dup if ." Fizz" then ;
: buzz 5 mod 0 = dup if ." Buzz" then ;
: fizz-buzz dup fizz swap buzz or invert ;
: fizzbuzz 26 1 do cr i fizz-buzz if i . then loop ;