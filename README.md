# Biology Quiz

A Bulgarian-language biology quiz for Windows, built with C# and Windows Forms
on .NET Framework 4.7.2. Play alone or take turns with a second player on the same
computer, using questions with text and images.

The application includes a question editor so you can build your own local
question bank. **No question bank is included in this repository.** Add questions
before starting your first game. The game screen's introductory text mentions
250 questions; that is legacy text, not bundled content.

## Features

- Solo and local two-player modes.
- Randomized questions, each used once per game.
- Four answer choices, each with a label and an image, plus a question image.
- Immediate answer feedback and three points for each correct answer.
- Final scores and a winner or tie result in two-player mode.
- Password-gated creation, editing, and deletion of local questions.
- Offline storage in `.qst` files, with no database or account setup.

## Requirements

To build the application, use Windows with Visual Studio's **.NET desktop
development** workload and the **.NET Framework 4.7.2 targeting pack**. The project
uses framework assemblies and has no third-party NuGet dependencies.

To run a compiled build, use Windows with .NET Framework 4.7.2 or a compatible
later .NET Framework runtime installed.

## Build and run

### Visual Studio

1. Open [`Biology quizz.sln`](Biology%20quizz.sln).
2. Select the `BiologyQuiz` project as the startup project if necessary.
3. Build the solution, then press **F5** to run with debugging or **Ctrl+F5** to
   run without debugging.

### PowerShell

From the repository root in a Visual Studio Developer PowerShell:

```powershell
MSBuild.exe '.\Biology quizz.sln' /t:Build /p:Configuration=Debug
& '.\src\BiologyQuiz\bin\Debug\Biology quizz.exe'
```

For a release build:

```powershell
MSBuild.exe '.\Biology quizz.sln' /t:Build /p:Configuration=Release
& '.\src\BiologyQuiz\bin\Release\Biology quizz.exe'
```

The executable retains the name `Biology quizz.exe`. Build output is written to
`src/BiologyQuiz/bin/Debug/` or `src/BiologyQuiz/bin/Release/`.

## Create your first question

The interface is primarily in Bulgarian. These steps include the button labels
shown in the application.

1. On the home screen, select **Добави нов въпрос** (Add a new question).
2. Enter the built-in editor password, `MyPassword1234`, and select **Следващ**
   (Next).
3. Enter a unique question name, the question text, and text for all four answers.
   The name becomes a filename, so use a simple name without path separators or
   characters that Windows disallows in filenames.
4. Click each image placeholder to choose the question image and all four answer
   images. The file picker includes PNG, JPG, and JPEG filters.
5. Select the correct answer number, from **1** to **4**.
6. Select **Създай въпроса** (Create the question). Every text field, image, and
   the correct-answer selection is required.

Use **Редактирай въпрос** (Edit a question) on the home screen to select an
existing question and save changes. Use **Изтрий въпрос** (Delete a question) to
select and delete one. Both actions use the same password prompt. The password
is hardcoded in [`Password.cs`](src/BiologyQuiz/Forms/Password.cs).

## Play a game

1. Choose **Брой играчи** (Number of players): **1** or **2**.
2. Enter a name for each participating player.
3. Select **Започни играта** (Start the game).
4. Select **Следващ** (Next) to display the first question.
5. Click an answer image. A correct answer adds **3 points**; an incorrect answer
   adds no points. Only the first answer click for a question is scored.
6. Select **Следващ** to continue. Answer the current question before advancing.
7. After the last answer, select **Следващ** to display the results.

In two-player mode, players take turns answering questions. **Спри играта** (Stop
the game) ends a session early and opens the results screen; in two-player mode,
the app may require waiting for the second player's turn before allowing this.

## Store and back up questions

The application creates an `Added Questions` folder **relative to its current
working directory**. Each question is saved as `<question name>.qst`, including
its text, correct answer, and images.

When launched with the PowerShell commands above, this folder is created at the
repository root. Visual Studio and other launch methods may use a different
working directory. To find an existing question bank, check the directory used
to launch the application as well as the build output directory.

To reuse a question bank, copy its `Added Questions` folder into the working
directory you will launch from. Back up this folder before editing, deleting, or
testing questions. Keep only question files in it: the game attempts to read
every file there and **deletes files it cannot load**.

Question files use .NET binary serialization. Load only questions you created or
trust. Local question banks and build output are ignored by Git.

## Project layout

```text
Biology quizz.sln
README.md
docs/
  DEVELOPMENT.md         Architecture, storage format, and maintenance checks
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

See the [developer guide](docs/DEVELOPMENT.md) for the screen responsibilities,
question formats, build checks, and current implementation limitations.

## Troubleshooting

| Symptom | What to check |
| --- | --- |
| `MSBuild.exe` is not found | Run the commands in a Visual Studio Developer PowerShell. |
| Build reports missing .NET Framework reference assemblies | Install the .NET Framework 4.7.2 targeting pack and the desktop development workload. |
| The game goes straight to results | Add questions first, or check that the working directory contains your `Added Questions` folder. |
| Questions appear missing after changing how you launch the app | Check the working directory; each launch location can have a separate question bank. |
| A new question will not save | Fill every text field, choose all five images, select the correct answer, and use a unique valid filename. |
| A question produces a loading error and disappears | The game deletes files that fail to load. Restore a trusted compatible copy from your backup. |
