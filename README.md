# Practice - Who Wants to Be a Millionaire?

This project is a simple console-based C# application that simulates a quiz game inspired by the popular game show "Who Wants to Be a Millionaire?". The player answers 3 multiple-choice questions, and if they answer at least 2 out of 3 correctly, they win the grand prize of 1 Million TL!

## Project Overview

The goal of this project is to practice the use of conditionals (`if / else` statements) and string comparison in C#. The program will:

1. Ask the player a series of 3 questions, each with two possible answers (A or B).
2. The player must answer each question, and their answer is checked for correctness (case-insensitive).
3. If the player answers 2 out of 3 questions correctly, they win the grand prize. If not, they lose.
4. After answering the first 2 questions, if the player cannot win anymore, the game skips the 3rd question and directly informs the player about the result.

### Example Questions

1. **Which animal spits when angry?**
   - a) Llama
   - b) Camel

2. **Which planet is closest to Earth?**
   - a) Venus
   - b) Mars

3. **What is the result of 5 * 2 + 8 / 2 - 2?**
   - a) 7
   - b) 12

*You can modify the questions in the code as per your preference.*

## How to Run the Project

To run this project, follow these steps:

1. Install [Visual Studio](https://visualstudio.microsoft.com/) or any other C# IDE.
2. Make sure [.NET SDK](https://dotnet.microsoft.com/download) is installed on your system.
3. Clone or download this repository to your local machine.
4. Open the project in Visual Studio by loading the solution file (`.sln`) or by opening the project folder.
5. Run the project using `Ctrl + F5` or via the terminal command:
    ```bash
    dotnet run
    ```
6. Follow the on-screen instructions to answer the quiz questions by entering "A" or "B" (case-insensitive).

### Game Flow

1. The program asks the player the first question and waits for the answer.
2. After submitting an answer (A or B), the program checks if it's correct and informs the player.
3. The game proceeds to the second question and follows the same process.
4. If the player has already lost the chance to win after two questions, the game skips the third question.
5. At the end, the program displays whether the player won the grand prize of 1 Million TL.

### Example Output

- **Correct answer feedback:** "Correct! You have 1 correct answer."
- **Wrong answer feedback:** "Wrong answer. You have 0 correct answers."
- **Final result:** "Congratulations! You won 1 Million TL!" or "Sorry, you did not win the grand prize."

## Technologies Used

- **C#**: The programming language used to create the application.
- **.NET Core**: Framework used to compile and run the application.
- **Visual Studio**: The integrated development environment (IDE) for writing, debugging, and running the code.

## Features

- 3 quiz questions with two answer choices (A or B).
- Keeps track of the number of correct answers.
- Uses conditional logic to determine if the player wins after answering the first two questions.
- Case-insensitive input for user answers.

## Contribution

This project is a simple practice exercise designed for learning purposes. Contributions are not necessary but feedback is always welcome for improvement.

## License

This project was developed for educational purposes and does not require any specific license.

![image](https://github.com/user-attachments/assets/87465fb8-8028-4510-bbdd-cba25b23db1c)
![image](https://github.com/user-attachments/assets/2f910bae-9ecc-420c-a83e-599acd9d8822)
