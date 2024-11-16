# Hangman Game by Edrian Visagas

Welcome to the **Hangman Game** — a fun and challenging word guessing game built using .NET MAUI. The goal of the game is simple: guess the hidden word by suggesting letters one at a time. However, every wrong guess brings you closer to losing, so play carefully!

## 🎮 **Gameplay**

The game is based on the classic **Hangman** rules:

- **Start the game**: A random word is selected from a predefined list of tech-related terms.
- **Guess the word**: The word is displayed as underscores (`_`), each representing a letter in the word.
- **Make guesses**: You can guess one letter at a time. If the letter is correct, it is revealed in the word.
- **Mistakes**: For every incorrect guess, a part of a stick figure is drawn, and you are allowed a limited number of mistakes (up to 7 incorrect guesses).
- **Win condition**: Guess the entire word correctly before the hangman is fully drawn.
- **Lose condition**: If you make too many mistakes (7), the hangman is fully drawn, and you lose.

## 📝 **Game Features**

- **Random Word Selection**: Words are picked from a curated list of tech-related terms like **Python**, **CSharp**, **JavaScript**, and others.
- **Hint Button**: If you're stuck, use the **Hint Button**! But be warned — hints cost **3 mistakes**, so use them wisely!
- **Reset Button**: Restart the game at any time to try a different word or begin a new round.
- **Game Status**: The number of mistakes is tracked and displayed at the top of the screen so you can see how many errors you've made.

### **Visuals**:
- The game visually represents your mistakes with an image of a "hangman" that is drawn step by step as you make incorrect guesses.
- **Current Hangman State**: An image is shown from `hang1.png` to `hang7.png` based on the number of mistakes made.

---

## 🏆 **How to Play**

1. **Start a New Game**: Click the "Play" button on the Home screen to start the game.
2. **Guess Letters**: Select letters from the alphabet to guess the hidden word.
3. **Use the Hint**: If you're stuck, click the "Hint (Costs 3 Errors)" button to reveal a random letter, but remember — it will cost you 3 mistakes!
4. **Reset**: If you'd like to start over, press the "Reset" button anytime to start a new game.
5. **Win or Lose**: Try to guess all letters before you make 7 mistakes. If you succeed, you win! If the hangman is drawn completely, you lose.

---

## 📱 **Screenshots**

Here are some screenshots of the game in action:

![Game Screenshot 1](assets/screenshots/screenshot1.png)
![Game Screenshot 2](assets/screenshots/screenshot2.png)

---

## 💻 **Technologies Used**

This project was built using the following technologies:

- **.NET MAUI**: A cross-platform framework for building native apps for Android, iOS, macOS, and Windows.
- **XAML**: Used for designing the user interface.
- **C#**: The primary programming language for game logic and handling user input.
- **CommunityToolkit.Maui**: Provides UI components and utilities, such as Popups, that enhance the game experience.

---

## 🛠️ **Installation**

To get started with the game locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/hangman-game.git
