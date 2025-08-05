# DCIT318 – Assignment 1

**Name:** Prince William  
**Student ID:** 11308636  
**Course:** DCIT 318 – Software Engineering  
**Assignment:** Console Applications – C#

## Overview

This repository contains three C# console applications:

1. **Grade Calculator**  
   Prompts the user to enter a numerical grade between 0–100 and returns the corresponding letter grade (A–F).

2. **Ticket Price Calculator**  
   Asks for the user's age and calculates the movie ticket price based on age. Children (≤12) and seniors (≥65) pay GHC7, otherwise GHC10.

3. **Triangle Type Identifier**  
   Takes three side lengths from the user and determines whether the triangle is Equilateral, Isosceles, or Scalene.

## How to Run

Make sure you have [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed.

```bash
# Clone the repo (if not done already)
git clone https://github.com/yourusername/dcit318-assignment1-11308636.git
cd dcit318-assignment1-11308636

# Run each project
cd GradeCalculator
dotnet run

cd ../TicketPriceCalculator
dotnet run

cd ../TriangleTypeIdentifier
dotnet run
