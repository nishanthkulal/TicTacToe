<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

</head>
<body>

<h1>Tic Tac Toe Game</h1>

<p>A simple two-player Tic Tac Toe game built using Unity (version 2021.3.43f1). The first player uses "X" and the second player uses "O".</p>

<h2>Features</h2>
<ul>
    <li><strong>Home Screen</strong>
        <ul>
            <li>Play button to start the game</li>
            <li>Quit button to exit the application</li>
        </ul>
    </li>
    <li><strong>Game Screen</strong>
        <ul>
            <li>Exit button to return to the Home Screen</li>
            <li>Replay button to restart the game</li>
            <li>Main game logic with a 3x3 grid</li>
        </ul>
    </li>
    <li><strong>Game Over Screen</strong>
        <ul>
            <li>Replay button to play again</li>
            <li>Home button to return to the Home Screen</li>
        </ul>
    </li>
</ul>

<h2>Game Logic</h2>
<p>Players take turns marking the spaces in a 3x3 grid. The game checks for win conditions after each turn. If a player wins or if the game ends in a draw, the Game Over screen is displayed.</p>

<h2>Concepts Used</h2>
<ul>
    <li><strong>Events</strong>: For handling player turns and game state changes.</li>
    <li><strong>Grid Layout Group</strong>: To create a responsive 3x3 grid for the game board.</li>
    <li><strong>Array</strong>: To store the state of the game board.</li>
</ul>

<h2>Getting Started</h2>
<ol>
    <li>Clone this repository:
        <pre><code>git clone https://github.com/nishanthkulal/TicTacToe.git</code></pre>
    </li>
    <li>Open the project in Unity 2021.3.43f1.</li>
    <li>Press Play to start the game.</li>
</ol>

<h2>How to Play</h2>
<ol>
    <li>Click on the squares in the grid to place your mark ("X" or "O").</li>
    <li>The first player to align three marks vertically, horizontally, or diagonally wins.</li>
    <li>If all squares are filled without a winner, the game ends in a draw.</li>
</ol>

<h2>License</h2>
<p>This project is open source.</p>

</body>
</html>
