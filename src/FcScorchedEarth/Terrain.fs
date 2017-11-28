module Terrain

open Geometry

type Terrain = { 
    Points: List<Point2d>
} 

let initialTerrain =     
    { 
        Points = [{X = 10.0; Y = 0.0;}; {X = -10.0; Y = 0.0;}]
    }

let randomYPositions = 
    let rand = System.Random()
    [for i in 1..10 do yield rand.NextDouble()]


let randomTerrain = { 
    Points = List.mapi (fun i yPoints -> ({X = float(i - 5); Y = (yPoints - 0.5)})) randomYPositions;
}

