# Biology Quiz

A Windows Forms biology quiz application targeting .NET Framework 4.7.2.

## Project layout

```text
Biology quizz.sln
src/
  BiologyQuiz/
    BiologyQuiz.csproj
    Program.cs           Application entry point
    App.config           Runtime configuration
    Forms/               Screens, with their .Designer.cs and .resx files
    Models/              Question data and serialization
    Services/            Question discovery and image file operations
    Properties/          Assembly metadata, settings, and generated resources
    Resources/           Images and application icon
```

Keep each form's `.cs`, `.Designer.cs`, and `.resx` files together. This is a
classic MSBuild project, so new files must also be included in `BiologyQuiz.csproj`.
Use Visual Studio's **Add** commands to maintain project entries and designer
dependencies automatically.

The existing `Biology_quizz` namespaces and `Biology quizz` assembly name are
preserved, including the type identity used by serialized question files.

## Build and run

On Windows, install Visual Studio with the **.NET desktop development** workload
and the **.NET Framework 4.7.2 targeting pack**. Open `Biology quizz.sln` and run
the `BiologyQuiz` project, or build from a Visual Studio Developer PowerShell:

```powershell
MSBuild.exe '.\Biology quizz.sln' /t:Build /p:Configuration=Debug
& '.\src\BiologyQuiz\bin\Debug\Biology quizz.exe'
```

Use `/p:Configuration=Release` for a release build; its output is in
`src/BiologyQuiz/bin/Release/`.

## Question data

The application creates an `Added Questions` folder relative to its working
directory and stores questions as `.qst` files. No question bank is included in
this repository; add questions through the application before starting a quiz.
When running from PowerShell, the working directory is the shell's current
directory. To reuse existing questions, copy their `Added Questions` folder into
that directory. Local questions and build output are ignored by Git.
