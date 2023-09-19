# Unity Tic Tac Toe Game (Starting Structure)

**Please Note:** This repository contains the starting structure of a Tic Tac Toe game and is not a complete game.

A simple and customizable mobile Tic Tac Toe game built with Unity. Play on various board sizes and challenge your friends. Includes win, lose, and draw logic.

## Table of Contents
- [Scripts](#scripts)
  - [GameManager Script](#gamemanager-script)
  - [BoardManager Script](#boardmanager-script)
  - [UIManager Script](#uimanager-script)
- [Getting Started](#getting-started)
- [Gameplay Instructions](#gameplay-instructions)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)
- [Contact Information](#contact-information)
- [Project Status](#project-status)

## Scripts

### GameManager Script

`GameManager.cs`: This script manages the game's flow and logic.

- Initializes variables, sets board size, and creates an empty game board.
- Handles player's moves.
- Checks for win, lose, and draw conditions.
- Resets the game.

### BoardManager Script

`BoardManager.cs`: This script manages the game board's visual representation and user interactions.

- References the GameManager.
- Handles user's input and updates the game.
- Updates the visual representation of the game board.

### UIManager Script

`UIManager.cs`: This script manages the game's user interface, including menus and buttons.

- References the GameManager.
- Provides UI elements like buttons and text.
- Starts a new game.
- Displays game over messages.

## Getting Started

### Prerequisites
- Unity Editor

### Installation
1. Clone the repository.
2. Open the project in Unity.

## Gameplay Instructions

- Launch the game and select your preferred board size.
- Take turns with another player (or AI).
- The first player to form a line (horizontal, vertical, or diagonal) of their symbol (X or O) wins.
- If the board is filled with no winner, it's a draw.

## Features

- Multiple board sizes to choose from.
- Engaging gameplay with win, lose, and draw logic.
- Customizable player vs. player or player vs. AI modes.

## Technologies Used

- Unity Editor
- C# for game logic

## Contributing

We welcome contributions to improve the game. Feel free to submit bug reports, feature requests, or pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact Information

- For inquiries, reach out to M. Asad Ali at (mailto:sheikhasad2662@gmail.com).

## Project Status

This project is actively maintained and open to contributions.

