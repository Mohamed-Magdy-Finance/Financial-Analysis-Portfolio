# 🏢 Juhayna Food Industries (EGX: JUFO) — Enterprise Financial Model

[![Excel](https://img.shields.io/badge/Microsoft_Excel-217346?style=for-the-badge&logo=microsoft-excel&logoColor=white)](https://www.microsoft.com/en-us/microsoft-365/excel)
[![Version](https://img.shields.io/badge/version-1.0.0-blue.svg)](https://github.com/MohamedMagdy/Juhayna-Financial-Model)
[![License: CC BY-NC 4.0](https://img.shields.io/badge/License-CC%20BY--NC%204.0-lightgrey.svg)](https://creativecommons.org/licenses/by-nc/4.0/)
[![GitHub stars](https://img.shields.io/github/stars/MohamedMagdy/Juhayna-Financial-Model?style=social)](https://github.com/MohamedMagdy/Juhayna-Financial-Model/stargazers)

> **An enterprise-grade, fully audited 3‑statement financial model for Juhayna Food Industries (EGX: JUFO), featuring a dynamic dashboard, scenario manager, and 70+ automated integrity checks.**

---

## 📖 Table of Contents

- [Overview](#-overview)
- [Key Statistics](#-key-statistics)
- [Enterprise Design Principles](#-enterprise-design-principles)
- [Model Architecture & Workflow](#-model-architecture--workflow)
- [Walkthrough & Screenshots](#-walkthrough--screenshots)
- [Getting Started](#-getting-started)
- [Repository Structure](#-repository-structure)
- [Skills Demonstrated](#-skills-demonstrated)
- [Built With](#-built-with)
- [Disclaimer](#-disclaimer)
- [Author](#-author)
- [License](#-license)

---

## 📊 Overview

This repository contains a comprehensive financial model for **Juhayna Food Industries (EGX: JUFO)**, developed entirely in Microsoft Excel. The model provides a complete platform for financial planning, analysis, valuation, and scenario planning.

Built using **industry‑standard enterprise FP&A and financial modeling best practices**, the model features a clean architecture, a **Single Source of Truth (SSoT)** reporting layer, and over **70 automated validation checks** to ensure data integrity and auditability.

---

## 📈 Key Statistics

| Metric | Value |
|:-------|------:|
| **Worksheets** | 33 |
| **Validation Checks** | 70 |
| **Health Score** | 100% (70/70 Checks Passed) |
| **Historical & Forecast Period** | 2016–2026 |
| **Scenarios** | 5 (Base, Optimistic, Conservative, Stress, Custom) |
| **Named Ranges** | 370+ |
| **KPIs** | 49+ |

---

## 🧠 Enterprise Design Principles

This model is built on a set of core design principles that reflect enterprise‑grade financial modeling standards:

| Principle | Description |
|:----------|:------------|
| **Single Source of Truth (SSoT)** | All downstream outputs source data exclusively from the Reporting Layer. |
| **No Hardcoded KPIs** | All KPIs are calculated dynamically via the KPI Engine. |
| **Fully Auditable** | Every value is traceable to its source via the Reporting Layer's source columns. |
| **Governance First** | A dedicated Control Panel with 70+ automated integrity checks continuously validates the model. |
| **Dynamic Scenario Engine** | 5 pre‑built scenarios flex key drivers with side‑by‑side comparison. |
| **Zero Circular References** | The model is structurally free of circular references. |
| **Power BI Integration Ready** | A flat‑table export is included for seamless BI ingestion. |

---

## 🧠 Model Architecture & Workflow

The model follows a strict enterprise architecture to ensure robustness, scalability, and auditability.

### Architecture Rules

1. **Reporting Layer** references KPI Engine only.
2. **Dashboard** references Reporting Layer only.
3. **Charts** reference Reporting Layer only.
4. **Sensitivity** references Reporting Layer only.
5. **Div & Analyst** references Reporting Layer or Market Data (exempt).
6. **Ratios** is exempt (peer‑comparability snapshot).
7. All named ranges resolve to Reporting Layer.

```mermaid
graph TD
    A[Raw Data Layer] --> B[Calculation Engine - KPI Engine];
    B --> C[Semantic Layer - Reporting SSoT];
    C --> D[Presentation Layer - Dashboard & Charts];
    C --> E[Governance Layer - Control Panel];
    D --> F[Power BI Export];
    E --> F;

    style A fill:#0B1F3A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style B fill:#1A2D4A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style C fill:#0B1F3A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style D fill:#1A2D4A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style E fill:#0B1F3A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style F fill:#1A2D4A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
```

---

## 🖼️ Walkthrough & Screenshots

### 1. Professional Cover Page
<p align="center">
  <img src="./images/01-Cover.png" alt="Cover Page" width="800">
</p>

### 2. Executive Dashboard
<p align="center">
  <img src="./images/02-Dashboard.png" alt="Executive Dashboard" width="800">
</p>

### 3. KPI Engine
<p align="center">
  <img src="./images/03-KPI-Engine.png" alt="KPI Engine" width="800">
</p>

### 4. Reporting Layer (Single Source of Truth)
<p align="center">
  <img src="./images/04-Reporting-Layer.png" alt="Reporting Layer" width="800">
</p>

### 5. Scenario Manager
<p align="center">
  <img src="./images/05-Scenario-Manager.png" alt="Scenario Manager" width="800">
</p>

### 6. Sensitivity Analysis
<p align="center">
  <img src="./images/06-Sensitivity.png" alt="Sensitivity Analysis" width="800">
</p>

### 7. Market Data Hub
<p align="center">
  <img src="./images/07-Market-Data-Hub.png" alt="Market Data Hub" width="800">
</p>

### 8. Control Panel
<p align="center">
  <img src="./images/08-Control-Panel.png" alt="Control Panel" width="800">
</p>

### 9. Model Architecture
<p align="center">
  <img src="./images/09-Architecture.png" alt="Model Architecture" width="800">
</p>

### 10. Audit Trail
<p align="center">
  <img src="./images/10-Audit-Trail.png" alt="Audit Trail" width="800">
</p>

---

## 🚀 Getting Started

### Prerequisites
- **Microsoft Excel** (Version 2016 or later, 64‑bit recommended).
- **S&P Capital IQ Add‑in** (optional — for LIVE market data mode).

### Installation & Usage
1. Clone the repository or download the files.
2. Open `Juhayna_v1.0.0_Production.xlsx`.
3. Enable Editing and explore the Executive Dashboard.

---

## 📁 Repository Structure

```text
Juhayna-Financial-Model/
│
├── README.md
├── LICENSE
├── images/
│   ├── 01-Cover.png
│   ├── 02-Dashboard.png
│   ├── 03-KPI-Engine.png
│   ├── 04-Reporting-Layer.png
│   ├── 05-Scenario-Manager.png
│   ├── 06-Sensitivity.png
│   ├── 07-Market-Data-Hub.png
│   ├── 08-Control-Panel.png
│   ├── 09-Architecture.png
│   └── 10-Audit-Trail.png
└── Juhayna_v1.0.0_Production.xlsx
```

---

## 💼 Skills Demonstrated
- **Financial Modeling:** 3‑Statement Integration, DCF Valuation, Scenario Analysis.
- **FP&A:** Forecasting, Budgeting, Variance Analysis, KPI Dashboards.
- **Excel Automation:** Dynamic Named Ranges, LET Functions, Data Validation.
- **Data Governance:** Audit Trails, Control Panels, Formula Governance.

---

## 🛠️ Built With

| Tool | Purpose |
|:-----|:--------|
| **Microsoft Excel** | Primary development platform |
| **S&P Capital IQ** | Optional live market data feed |
| **Power BI** | External reporting and visualization |
| **Git** | Version control |

---

## ⚠️ Disclaimer

**This model is an independent analytical work and is provided for educational and portfolio demonstration purposes only. It is not intended as investment advice.**

- The financial data used is based on publicly available information.
- This model is **not affiliated with or endorsed by Juhayna Food Industries.**
- Users are advised to conduct their own research and consult with qualified financial professionals before making any investment decisions.

---

## 👤 Author

**Mohamed Magdy**
- FP&A Analyst & MBA Candidate – Finance & Investment
- **LinkedIn:** [linkedin.com/in/mohamed-magdy-finance](https://www.linkedin.com/in/mohamed-magdy-finance)
- **GitHub:** [github.com/MohamedMagdy](https://github.com/MohamedMagdy)

---

## 📄 License
Licensed under the **Creative Commons Attribution-NonCommercial 4.0 International License**.

---

<p align="center">
  © 2026 Mohamed Magdy. All rights reserved.
</p>