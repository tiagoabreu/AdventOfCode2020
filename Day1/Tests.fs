﻿module Tests

open Xunit
open Program
open System

[<Fact>]
let ``Calculate Part1 Test Case`` () =
    let input = [|1721; 979; 366; 299; 675; 1456|];
    let result = calculatePart1 2020 input
    Assert.Equal (514579, result)

[<Fact>]
let ``Real Case Part1`` () =
    let result = calculatePart1FromFile "input.txt"
    Console.WriteLine result

[<Fact>]
let ``Calculate Part2 Test Case`` () =
    let input = [|1721; 979; 366; 299; 675; 1456|];
    let result = calculatePart2 2020 input
    Assert.Equal (241861950, result)

[<Fact>]
let ``Real Case Part2`` () =
    let result = calculatePart2FromFile "input.txt"
    Console.WriteLine result