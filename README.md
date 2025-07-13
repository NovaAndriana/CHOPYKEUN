
# 🟢 CHOPYKEUN - Terminal File Copy Tool

![Banner](https://img.shields.io/badge/Built%20With-VB.NET-blue.svg) ![License](https://img.shields.io/badge/License-MIT-green.svg)

> Terminal-style powerful data copy tool based on `robocopy`, wrapped with a hacker aesthetic.

---

## 🔥 What is CHOPYKEUN?

**CHOPYKEUN** is a terminal-based file copying utility built with VB.NET.  
It wraps the native `robocopy` command in a sleek hacker-style interface, complete with:

- ✅ Real-time terminal output (like Linux CLI)
- ✅ Support for full folder copy or selected files only
- ✅ Live color-coded logs
- ✅ Auto log saving with timestamp
- ✅ ASCII logo branding
- ✅ **Created by Nova**

---

## 💻 Screenshot

```
   ██████╗██╗  ██╗ ██████╗ ██████╗ ██╗   ██╗██╗  ██╗███████╗██╗   ██╗███╗   ██╗
  ██╔════╝██║  ██║██╔═══██╗██╔══██╗╚██╗ ██╔╝██║ ██╔╝██╔════╝██║   ██║████╗  ██║
  ██║     ███████║██║   ██║██████╔╝ ╚████╔╝ █████╔╝ █████╗  ██║   ██║██╔██╗ ██║
  ██║     ██╔══██║██║   ██║██╔═══╝   ╚██╔╝  ██╔═██╗ ██╔══╝  ╚██╗ ██╔╝██║╚██╗██║
  ╚██████╗██║  ██║╚██████╔╝██║        ██║   ██║  ██╗███████╗ ╚████╔╝ ██║ ╚████║
   ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝        ╚═╝   ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚═╝  ╚═══╝
                          CHOPYKEUN TERMINAL - CREATED BY NOVA
```

---

## 🚀 Features

- 📂 Input `Source` folder
- 💾 Input `Destination` folder
- 🔘 Choose:
  - Copy **all files/folders**
  - Copy **specific files/folders**
- 📝 Save logs automatically with timestamp
- 🎨 Terminal interface with **green/alert colors**
- ⚙ Built-in error highlighting
- 📦 Portable, no installation required

---

## 🛠 How to Use

### 🧑‍💻 Compile via Visual Studio
1. Open solution in **Visual Studio** (VB.NET Console App)
2. Build → `bin\Release\CHOPYKEUN.exe`
3. Run it via command line or double click

### 🏁 Or Run Directly
1. Open Command Prompt
2. Navigate to the `CHOPYKEUN.exe` location
3. Run:
   ```
   CHOPYKEUN.exe
   ```

---

## 📁 Log Output

Log files are saved automatically in the destination folder:
```
log_shadowcopy_YYYYMMDD_HHMMSS.txt
```

---

## 📦 Tech Stack

- VB.NET Console App (.NET Framework)
- Robocopy (Windows built-in)
- Console I/O handling
- ASCII Logo Generator: [patorjk.com/software/taag](http://patorjk.com/software/taag)

---

## 🧑‍🎓 Created By

> 👨‍💻 **Nova Andriana**  
> Developer & Engineer | Terminal UI enthusiast  
> _"Backup it like a hacker, clean and traceable."_ 🚀

---

## 📄 License

This project is open-sourced under the [MIT License](LICENSE).
