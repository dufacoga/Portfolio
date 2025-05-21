# 🌐 Blazor Developer Portfolio

A responsive and elegant developer portfolio built entirely with **Blazor WebAssembly** and **pure CSS Grid**.  
This project serves as a modern personal landing page to showcase GitHub projects, skills, certifications, and experience, with support for dark/light themes and full responsiveness across devices.

---

## 🚀 Live Demo

👉 [Visit Demo]() &nbsp;

---

## 🖼️ Preview

![Portfolio Desktop Preview](https://github.com/user-attachments/assets/b43dda5a-7a81-4a64-b7a7-44a482f858ff)

### 💡 Overview

📌 **What to show in this image:**
- Profile photo
- Header title
- Contact info
- Tech stack
- GitHub Projects on the right
- Experience
- Publications

---

### 📱 Responsive & Theme Switching

**The responsive behavior (mobile ↔️ desktop)**

https://github.com/user-attachments/assets/05675604-e5ba-480e-982b-48f493536efa

**Switching between themes (dark, light, default)**

https://github.com/user-attachments/assets/7ac36602-171f-4d8f-b98c-b5ca5c68c182

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

```
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
│   ├── service-worker.published.js
│   ├── css/
│   │   ├── app.css
│   │   └── style.css
│   ├── js/
│   │   ├── fontawesome.js
│   │   └── themetoggle.js
│   └── images/
│       ├── profile.jpg
│       ├── illustration-gallery-icon.png
│       └── amazonawsarticles.png
```

---

## 🔧 How to Run Locally

```bash
git clone https://github.com/your-username/portfolio.git
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

## 👤 Design inspired by 🌐 [Ariful Alam](https://github.com/arifszn)

## 👤 Author

**Douglas Cortes**  
💼 [LinkedIn](https://www.linkedin.com/in/dufacoga)  
🌐 [dufacoga.github.io](https://dufacoga.github.io)
