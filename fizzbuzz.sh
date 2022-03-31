#!/bin/bash
for ((i>1;i<=20;i++)); do
    if ! ((i%3)); then
      echo "Fizz"
    elif ! ((i%3,5)); then
        echo "FizzBuzz"
    elif ! ((i%3|5)); then
        echo "Nothing"
    fi;
done