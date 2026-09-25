# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

Lab exercises (LABO 01) for an "AI-driven Software Engineering" course. Each exercise is a separate, self-contained .NET 10 console app in its own `ExerciseNN/` folder (`ExerciseNN.csproj` + `Program.cs`). There is no solution file, no shared code between exercises, and no test projects.

All projects use the same csproj settings: `net10.0`, `OutputType=Exe`, `ImplicitUsings` and `Nullable` enabled. Programs use top-level statements (no `Main`/class). Code comments may be in Dutch.

The lab is complete: Exercise01–Exercise10 are all merged into `main`.

| Exercise | What it does |
|---|---|
| 01 | Hello World |
| 02 | Sum of two integers |
| 03 | Menu-driven calculator (loop + local function `ReadNumber`) |
| 04 | Count favorite colors with a `Dictionary`, print each in its console color |
| 05 | List classrooms with enough seats (seats ≥ 2 × students), sorted by name |
| 06 | List shoppers whose cart total exceeds a given value |
| 07 | Map scores (0–5) to grade labels with `switch` |
| 08 | Number guessing game with `Random` |
| 09 | Project price: land + building + 21% VAT |
| 10 | Clothing store order total using a price `Dictionary` |

## Commands

Run from the repo root (there is no .sln, so always target a project folder):

```powershell
dotnet run --project .\Exercise02      # build + run one exercise
dotnet build .\Exercise02              # build only
```

`dotnet run .\Exercise02` (without `--project`) does NOT work — the path is passed as a program argument.

If the build fails with MSB3027 "file is locked", the exercise is still running in a terminal. To verify a build without touching the user's running app, build to a separate output folder: `dotnet build .\ExerciseNN -o <temp dir>`.

Most exercises read from `Console.ReadLine()`, so they can be tested non-interactively by piping input, e.g. `printf '2\n3\n1\n' | <exe>`. Piped/redirected output shows `€` as `?` unless `Console.OutputEncoding = System.Text.Encoding.UTF8` is set.

New exercise: `dotnet new console -o ExerciseNN` (keeps the naming convention).

## Git workflow

- One branch per exercise: `feature/exerciseNN`, branched from `main`.
- When an exercise is finished it is committed on its branch, the branch is pushed, merged into `main` (fast-forward), and `main` is pushed.
- "next exercise" from the user means: build-check the current exercise, then do the step above, then create `feature/exercise(NN+1)` from `main` and scaffold `Exercise(NN+1)`.
