# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

Lab exercises (LABO 01) for an "AI-driven Software Engineering" course. Each exercise is a separate, self-contained .NET 10 console app in its own `ExerciseNN/` folder (`ExerciseNN.csproj` + `Program.cs`). There is no solution file, no shared code between exercises, and no test projects.

All projects use the same csproj settings: `net10.0`, `OutputType=Exe`, `ImplicitUsings` and `Nullable` enabled. Programs use top-level statements (no `Main`/class). Code comments may be in Dutch.

## Commands

Run from the repo root (there is no .sln, so always target a project folder):

```powershell
dotnet run --project .\Exercise02      # build + run one exercise
dotnet build .\Exercise02              # build only
```

`dotnet run .\Exercise02` (without `--project`) does NOT work — the path is passed as a program argument.

New exercise: `dotnet new console -o ExerciseNN` (keeps the naming convention).

## Git workflow

- One branch per exercise: `feature/exerciseNN`, branched from `main`.
- When an exercise is finished it is merged into `main`, and `main` is merged into the next exercise's branch.
