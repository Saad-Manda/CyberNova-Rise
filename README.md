# 🚀 CyberNova Rise

**CyberNova Rise** is a 3D Unity-based space game where the player controls a rocket and navigates from a launch pad to a landing pad while avoiding obstacles. The game features simple but challenging 2D movement mechanics in a 3D space environment.

---

## 🎮 Gameplay

- Control a rocket and guide it safely through obstacles to reach the landing pad.
- The game features **three unique levels**, each with increasing difficulty.

### 🎮 Controls

| Action       | Keyboard         | Game Controller       |
|--------------|------------------|------------------------|
| Thrust (Up)  | `Space`          | `Right Trigger`       |
| Move Left    | `A` / `←`        | Left of Left Stick    |
| Move Right   | `D` / `→`        | Right of Left Stick   |
| Exit Game    | `Escape`         | –                     |

> Movement is 2D (left, right, up), but the world is rendered in 3D.

---

## 🌌 Environment

- The game is set in a stylized **space/Mars-like environment** with red skies and immersive terrain.
- Includes **sound effects** for an engaging experience.

---

## 🛠️ Built With

- **Unity 6**
- **C#**

---

## 📽️ Preview

https://github.com/user-attachments/assets/f26b96d0-2608-437f-b99e-d255f38f753a

---

## 🕹️ How to Play

You can test and play the game in the following ways:

1. **🌐 Play Online (Unity Play)**  
   👉 [Play CyberNova Rise on Unity Play](https://play.unity.com/en/games/cd40a436-5871-4b54-a8ec-d87434749baf/cybernova-rise)

2. **Play in Unity Editor**  
   - Clone this repository.
   - Open the project in **Unity 6**.
   - Hit **Play** in the editor.

3. **Using Builds**

## 📦 Builds
You can find the latest builds of the game in the [**Builds**](./Builds) folder:

- **Windows `.exe` Build**
- **WebGL Build** (for browser play)

### 🖥️ Windows (.exe)

To run the Windows build:
1. Unzip the folder (if using the compressed version).
2. Open the `.exe` file.

> ⚠️ **Note**: You might see a warning from **Windows Defender SmartScreen** saying  
> *"Windows protected your PC"*.  
> This happens because the game is not digitally signed (common for indie games).
>
> To bypass it:
> - Click **More info**
> - Then click **Run anyway**

### 🌐 WebGL (Browser Build)

The WebGL version of the game is available in the [`./Builds/Web`](./Builds/Web) folder.

> 💡 **Note**: To run the WebGL version locally, you must serve it using a local web server.  
> Opening `index.html` directly from your file explorer (file:// protocol) may not work in some browsers.

#### 👉 Local Hosting Options:
- **VS Code Live Server Extension**
- `python3 -m http.server`
- `npx http-server`

---
## 🪐 License
- This project is licensed under the [MIT License](LICENSE).

## 🙌 Acknowledgements
- Thanks to the Unity and GameDevTV for tutorials and assets.
