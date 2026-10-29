# Developer guide

## Build configuration

The application is a single C# Windows Forms executable targeting .NET Framework
4.7.2. It uses a classic, non-SDK MSBuild project with explicit file entries and
supports `Debug|AnyCPU` and `Release|AnyCPU` configurations.

From the repository root in a Visual Studio Developer PowerShell:

```powershell
MSBuild.exe '.\Biology quizz.sln' /t:Rebuild /p:Configuration=Debug
MSBuild.exe '.\Biology quizz.sln' /t:Rebuild /p:Configuration=Release
```

There is no automated test project or CI configuration in the repository.
Manual checks are described below.

## Application structure

All application types currently use the `Biology_quizz` namespace, with generated
settings and shared resources in `Biology_quizz.Properties`. Folder names group
responsibilities without changing existing type identities.

| File or type | Responsibility |
| --- | --- |
| [`Program`](../src/BiologyQuiz/Program.cs) | Enables Windows Forms visual styles and starts the `Beginning` form. |
| [`Beginning`](../src/BiologyQuiz/Forms/Beginning.cs) | Home screen, player setup, question-directory creation, and navigation. Holds shared player and navigation state in static fields. |
| [`Password`](../src/BiologyQuiz/Forms/Password.cs) | Compares the entered editor password and routes to question creation, selection for editing, or deletion. |
| [`ChooseName`](../src/BiologyQuiz/Forms/ChooseName.cs) | Lists saved question names and opens the selected question in the editor. |
| [`AddNewQuestion`](../src/BiologyQuiz/Forms/AddNewQuestion.cs) | Collects and validates question fields, selects images, and creates or replaces question files. |
| [`DeleteQuestion`](../src/BiologyQuiz/Forms/DeleteQuestion.cs) | Lists questions and deletes the selected file. |
| [`TheGame`](../src/BiologyQuiz/Forms/TheGame.cs) | Loads the question file list, chooses questions randomly, handles answers, alternates turns, and tracks scores. |
| [`EndGame`](../src/BiologyQuiz/Forms/EndGame.cs) | Displays final scores, winner or tie text, and the question count. Resets player scores when loaded. |
| [`Question`](../src/BiologyQuiz/Models/Question.cs) | Serializable question model with binary-file and directory import/export methods. |
| [`Questing`](../src/BiologyQuiz/Services/Questing.cs) | Reads question filenames from `Added Questions` and removes their final four characters for display. |
| [`ImageFromFile`](../src/BiologyQuiz/Services/ImageFromFile.cs) | Reads images from files and writes bitmaps. |

The main navigation is `Program` → `Beginning` → `TheGame` → `EndGame`.
Question management goes through `Password`, which uses `Beginning.opt` to choose
creation (`0`), editing (`1`), or deletion (`2`). Editing first opens `ChooseName`
and then reuses `AddNewQuestion` with the saved values.

## Question data

### Model

| Property | Meaning |
| --- | --- |
| `Condition` | Question text. |
| `ImageToQuest` | Main question image. |
| `OptLabels` | Four answer labels, indexed from `0` to `3`. |
| `Options` | Four answer images, indexed from `0` to `3`. |
| `Answer` | Correct answer number, from `1` to `4`. |

The editor enforces populated text, five images, and an answer selection. The
model's public setters do not independently validate these constraints.

### Binary files used by the application

`Question.ExportToFile` serializes the entire question, including images, using
`BinaryFormatter`. `Question.ImportFromFile` deserializes it. The UI stores these
files under `Added Questions/<name>.qst`, relative to the process working
directory. There is no separate database, schema version, or question manifest.

Existing serialized files depend on the `Biology_quizz.Question` type and the
`Biology quizz` assembly identity. Changes to these identities or serialized
fields need a compatibility plan. Treat `.qst` files as trusted local data;
`BinaryFormatter` is not suitable for accepting untrusted files.

### Directory format available in code

`Question.ImportFromDirectory` and `Question.ExportToDirectory` support a second
format. These methods are not exposed by the current UI.

```text
<question directory>/
  QuestStrings.txt
  PicForQuestion.png
  Opt1Pic.png
  Opt2Pic.png
  Opt3Pic.png
  Opt4Pic.png
```

`QuestStrings.txt` contains six lines in this order: question text, answer labels
1–4, and the correct answer number. All five image files are required. The
line-based format cannot round-trip embedded newlines in question or answer text.

## Maintaining forms and resources

- Keep a form's `.cs`, `.Designer.cs`, and `.resx` files in the same directory.
- Use the Visual Studio designer for layout changes. Put behavior in the form's
  main `.cs` file.
- Add new files through Visual Studio, or explicitly add them to
  `BiologyQuiz.csproj`. Preserve `DependentUpon` entries for designer files and
  form resources.
- Manage shared images through `Properties/Resources.resx`; its file references
  point to `Resources/`. Regenerate `Resources.Designer.cs` using the resource
  editor after changing shared resources.
- Keep `ApplicationIcon` in the project file aligned with the icon's path.
- Keep generated build output and local question banks out of version control.

## Manual verification

Use a disposable question bank and preserve a backup of any real questions.

1. Rebuild both Debug and Release configurations.
2. Launch the application from a known working directory and confirm that the
   home screen and its background image load.
3. Create at least two questions with all required text and images, using
   different correct-answer positions. Confirm empty fields are rejected and a
   duplicate name does not overwrite an existing question in creation mode.
4. Edit a question, close the editor, and reopen it to confirm that its text,
   images, and correct-answer selection persist.
5. Play a solo game. Check that a correct answer adds three points, a wrong
   answer adds none, and the app requires an answer before advancing. Click each
   answer only once during the normal gameplay check.
6. Play a two-player game with one click per answer. Confirm alternating players,
   separate scores, no repeated questions, and the final result display.
7. Delete a disposable question and confirm its `.qst` file is removed.
8. Restart from the same working directory and confirm the remaining questions
   are available.

## Current implementation limitations

- Question files that fail to load during play are deleted automatically. The
  loader reads every file in `Added Questions`, without filtering extensions.
- Editing deletes the original question before writing its replacement, so a
  failed save can lose the original. There is no undo or automatic backup.
- The editor password is a hardcoded string in `Password.cs`. It provides a
  local UI gate and can be read from the source.
- `PicturesCode` guards score changes after the first answer, but toggles turn
  state on every answer-image click. Extra clicks can therefore disrupt the
  expected player order.
- Shared game state is stored in static fields. `EndGame` resets scores, but
  closing the game window directly bypasses that reset.
- The directory exporter catches image-save errors without reporting them, so
  a completed export call does not guarantee that every image was written.
- The introductory game text mentions 250 questions even though the repository
  contains no question bank. The actual game reads files from the local folder.
