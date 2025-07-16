# 🌐 Personal Portfolio Powered by Blazor WebAssembly

<p align="center">
  <a href="https://github.com/dufacoga/portfolio/issues"><img src="https://img.shields.io/github/issues/dufacoga/portfolio"/></a>
  <a href="https://github.com/dufacoga/portfolio/stargazers"><img src="https://img.shields.io/github/stars/dufacoga/portfolio"/></a>
  <a href="https://github.com/dufacoga/portfolio/network/members"><img src="https://img.shields.io/github/forks/dufacoga/portfolio"/></a>
  <a href="https://github.com/dufacoga/portfolio/commits/master"><img src="https://img.shields.io/github/last-commit/dufacoga/portfolio"/></a>
  <a href="https://github.com/dufacoga/portfolio/blob/master/CONTRIBUTING.md"><img src="https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat"/></a>
  <a href="https://github.com/dufacoga/portfolio/blob/master/LICENSE"><img src="https://img.shields.io/github/license/dufacoga/portfolio"/></a>
</p>


A responsive and elegant personal portfolio built entirely with **Blazor WebAssembly** and **pure CSS Grid**.  
This project serves as a modern personal landing page to showcase GitHub projects, skills, certifications, and experience, with support for dark/light themes and full responsiveness across devices.

---

## 🚀 Live Demo

<p align="center">
  <a href="https://dufacoga.github.io">
    <img src="https://github.com/user-attachments/assets/3a7d74be-678b-483e-835a-3766bc0bd653" alt="Live Demo Preview" width="90%" />
  </a>
</p>
<p align="center">
  <a href="https://dufacoga.github.io/Portfolio">View Demo</a>
  ·
  <a href="https://github.com/dufacoga/Portfolio/issues">Report Bug</a>
</p>

---

## 🖼️ Overview

📌 **This image shows the full layout:**
- Profile photo
- Header title
- Contact info
- Tech stack
- GitHub Projects
- Experience and Publications

---

## 📱 Responsive & Theme Switching

**The responsive behavior (mobile ↔️ desktop)**
<p align="start">
  <img src="https://github.com/user-attachments/assets/a25078f1-7467-4fde-b080-9bb6edffdffc" alt="Responsive Demo" width="75%" />
</p>

**Switching between themes (dark, light, default)**
<p align="start">
  <img src="https://github.com/user-attachments/assets/4a66446d-2b9c-4de3-b9f5-ef0d3ab3a6db" alt="Theme Switching Demo" width="75%" />
</p>

---

## ✨ Features

- 🧱 **Built with Blazor WebAssembly**
- 🎨 **Pure CSS Grid layout** – no frameworks
- 🌗 **Light / Dark / Default theme switcher**
- 📦 **Real-time GitHub project fetching** via GitHub API
- 🔄 **Reusable UI components** like `<Card>`, `<InfoContact>`, `<InfoSkill>`
- 📱 **Fully responsive design** for desktop and mobile
- 🧠 **Modular and scalable** – easily extend sections like Projects, Articles, Skills

---

## 📂 Project Structure

```bash
📁 Portfolio/
├── App.razor
├── _Imports.razor
├── Program.cs
├── Portfolio.csproj
├── Properties/
│   └── launchSettings.json
│
├── Pages/
│   └── Home.razor
│
├── Model/
│   └── GitHubProject.cs
│
├── Layout/
│   ├── MainLayout.razor
│   ├── Card.razor
│   ├── GroupCard.razor
│   ├── Contact.razor
│   ├── Header.razor
│   ├── Profile.razor
│   ├── ThemeToggle.razor
│   ├── GeneralInfoCard.razor
│   ├── InfoContact.razor
│   ├── InfoSkill.razor
│   ├── InfoGeneral.razor
│   ├── InfoGithubProject.razor
│   ├── InfoHashtag.razor
│   ├── InfoPublication.razor
│   ├── InfoMyProject.razor
│   └── InfoMyArticle.razor
│
├── wwwroot/
│   ├── index.html
│   ├── manifest.webmanifest
│   ├── service-worker.js
│   ├── css/
│   │   └── style.css
│   ├── js/
│   │   └── themetoggle.js
│   └── images/
│       ├── profile.jpg
│       ├── illustration-gallery-icon.png
│       └── amazonawsarticles.png
```

---

## 🔧 How to Run Locally

```bash
git clone https://github.com/dufacoga/portfolio.git
cd portfolio
dotnet run
```

Then open `http://localhost:5000` in your browser.

---

## 🛠️ Built With

- [.NET 8 Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [Font Awesome 5.15](https://fontawesome.com/)
- [CSS Grid Layout](https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_Grid_Layout)
- [GitHub REST API](https://docs.github.com/en/rest)

---

## 📄 License

This project is open source under the [MIT License](LICENSE).

---

## 👤 Design inspired by 

**Ariful Alam**  
:octocat:  [GitHub](https://github.com/arifszn)

## 👤 Author 

**Douglas Cortes**  
💼 [LinkedIn](https://www.linkedin.com/in/dufacoga)  
🌐 [dufacoga.github.io](https://dufacoga.github.io)
