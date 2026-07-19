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

Built using **industry‑standard enterprise FP&A and financial modeling best practices**, the model features a clean 5‑layer architecture, a **Single Source of Truth (SSoT)** reporting layer, and over **70 automated validation checks** to ensure data integrity and auditability.

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
| **Fully Auditable** | Every value is traceable to its source via the Reporting Layer's `Source Sheet`, `Source Cell`, and `Lineage Path` columns. |
| **Governance First** | A dedicated Control Panel with 70+ automated integrity checks continuously validates the model. |
| **Dynamic Scenario Engine** | 5 pre‑built scenarios flex key drivers with side‑by‑side comparison and dashboard impact analysis. |
| **Zero Circular References** | The model is structurally free of circular references. |
| **Power BI Integration Ready** | A flat‑table export (`tbl_PBI_Export`) is included for seamless BI ingestion. |
| **Formula Registry & Documentation** | All named ranges (370+) are cataloged in the Model Registry; a full Formula Governance ledger tracks exceptions. |
| **Data Lineage & Transparency** | Full documentation ensures every assumption and calculation is transparent and reviewable. |

---

## 🧠 Model Architecture & Workflow

The model follows a strict **5‑layer enterprise architecture** to ensure robustness, scalability, and auditability.

### Data Flow Workflow

Public Financial Statements & Market Data│▼┌──────────────────────┐│    Raw Data Layer    ││ (IS, BS, CF, Market) │└──────────────────────┘│▼┌──────────────────────┐│ Calculation Engine   ││    (KPI Engine)      │└──────────────────────┘│▼┌──────────────────────┐│    Semantic Layer    ││  (Reporting Layer)   ││   Single Source of   ││      Truth (SSoT)    │└──────────────────────┘│▼┌──────────────────────┐│ Presentation Layer   ││ (Dashboard, Charts,  ││  Sensitivity, Ratios)│└──────────────────────┘│▼┌──────────────────────┐│   Governance Layer   ││ (Control Panel,      ││  Audit Trail,        ││  Formula Governance) │└──────────────────────┘│▼┌──────────────────────┐│  Power BI Export     │└──────────────────────┘
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
    A[Raw Data Layer<br>(IS, BS, CF, Market)] --> B[Calculation Engine<br>(KPI Engine)];
    B --> C[Semantic Layer<br>(Reporting Layer - SSoT)];
    C --> D[Presentation Layer<br>(Dashboard, Charts)];
    C --> E[Governance Layer<br>(Control Panel, Audit Trail)];
    D --> F[Power BI Export];
    E --> F;

    style A fill:#0B1F3A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style B fill:#1A2D4A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style C fill:#0B1F3A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style D fill:#1A2D4A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style E fill:#0B1F3A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
    style F fill:#1A2D4A,stroke:#D4AF37,stroke-width:2px,color:#FFFFFF
🖼️ Walkthrough & Screenshots1. Professional Cover PageThe Cover Page establishes the model's professional identity with a dark navy gradient background and gold accent. It features the company name and ticker, a dynamic Active Scenario badge linked to the dashboard, and the author's credentials and contact information.2. Executive DashboardThe Executive Dashboard provides a real‑time executive view with dynamic KPI cards (Revenue, EBITDA, Net Income, ROE), Year/Scenario/Currency selectors, and a Model Health indicator showing 100% Health Score. The Scenario Impact section visualizes the delta between the active scenario and the base case.3. KPI EngineThe KPI Engine serves as the central calculation layer, housing all financial metrics in one place. This ensures consistency across the entire model. The engine includes profitability, returns, liquidity, solvency, efficiency, and growth metrics, all calculated dynamically from the raw financial data.4. Reporting Layer (Single Source of Truth)The Reporting Layer is the model's Single Source of Truth (SSoT). Every value in this sheet is traced back to its origin through Source Sheet, Source Cell, and Lineage Path columns. All downstream outputs (Dashboard, Charts, Sensitivity) read exclusively from this layer, ensuring data integrity and auditability.5. Scenario ManagerThe Scenario Manager allows users to switch between 5 pre‑built scenarios: Base, Optimistic, Conservative, Stress, and Custom. The side‑by‑side comparison table shows Revenue, EBITDA, NOPAT, and Terminal Value across all scenarios, enabling rapid what‑if analysis and strategic planning.6. Sensitivity AnalysisAdvanced sensitivity analysis includes:Tornado Analysis – flexing 7 assumptions ±10% to identify key value drivers.One‑Way Sensitivity – Revenue Growth → Net Income waterfall.Two‑Way Sensitivity – Revenue Growth × EBITDA Margin heat map.Break‑even Analysis – Revenue required for Net Income = 0 with margin of safety.7. Market Data HubThe Market Data Hub supports dual‑mode operation:LIVE – connects to S&P Capital IQ for real‑time data.MANUAL – allows user overrides when the feed is unavailable.Features include data validation, quality scoring, provider status monitoring, and graceful fallback mechanisms.8. Control PanelThe Control Panel is the model's governance center, featuring 70 automated integrity checks with a 5‑tier severity classification (Critical, High, Medium, Low, Information). The Health Score of 100% (70/70 checks passing) provides instant confidence in the model's quality.9. Model Architecture (Dependency Map)The Dependency Map visualizes the model's 5‑layer architecture and enforces architecture rules. It audits references to ensure that downstream sheets read exclusively from the Reporting Layer, preventing spaghetti dependencies and maintaining a clean, maintainable structure.10. Audit TrailThe Audit Trail provides a complete change log with version tracking, approval workflow, and 70+ historical entries. Every change is documented with date, user, sheet, cell, old/new values, change type, reason, and approver, meeting the highest standards of transparency and governance.🚀 Getting StartedPrerequisitesMicrosoft Excel (Version 2016 or later, 64‑bit recommended).S&P Capital IQ Add‑in (optional — for LIVE market data mode).InstallationClone the repository:Bashgit clone [https://github.com/MohamedMagdy/Juhayna-Financial-Model.git](https://github.com/MohamedMagdy/Juhayna-Financial-Model.git)
Open the model:Navigate to the folder and open Juhayna_v1.0.0_Production.xlsx.Enable Editing:Click "Enable Editing" to allow the model's dynamic features to work.Configure Market Data:Go to the 📡 Market Data Hub sheet.Choose LIVE (requires CIQ add‑in) or MANUAL (enter values manually).Start Exploring:Open the 🏢 Dashboard to see the executive summary.Use the selectors (Year, Scenario, Currency) to interact with the model.Verify Health:Open the ✅ Control Panel to ensure all 70 checks are passing.Manual Data EntryIf the CIQ feed is unavailable:Set Data Mode to MANUAL on the 📡 Market Data Hub.Enter current market data in the Manual Override section (F28:F34).All downstream sheets will automatically use the manual values.📁 Repository StructurePlaintextJuhayna-Enterprise-Financial-Model/
│
├── README.md                       # Project documentation
├── LICENSE                         # CC BY-NC 4.0 License
│
├── images/                         # Screenshots for README
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
│
└── Juhayna_v1.0.0_Production.xlsx    # Main Excel model file
💼 Skills DemonstratedSkill AreaSpecific CompetenciesFinancial Modeling3‑Statement Integration, DCF Valuation, Scenario & Sensitivity AnalysisFP&AForecasting, Budgeting, Variance Analysis, KPI DashboardsCorporate FinanceCapital Structure, Leverage Analysis, Return Metrics (ROE, ROA, ROIC)Excel AutomationDynamic Named Ranges, LET Functions, Data Validation, Conditional FormattingData GovernanceAudit Trails, Control Panels, Formula Governance, Model RegistryPower BI IntegrationOptimized Flat‑Table Export for Seamless BI IngestionDashboard DesignInteractive Executive Dashboards with Sparklines and Status IndicatorsFinancial Statement AnalysisHistorical & Forecast Analysis, Ratio Analysis, Growth Trends🛠️ Built WithToolPurposeMicrosoft ExcelPrimary development platformS&P Capital IQOptional live market data feedPower BIExternal reporting and visualization (export table included)GitVersion controlExcel Features UsedDynamic Arrays (INDEX, MATCH, XLOOKUP)LET Function (for readability)Named Ranges (370+ with taxonomy)Excel Tables (for Power BI export)Conditional Formatting (semantic status colors)Data Validation (for user inputs)Sheet Protection (enterprise security)⚠️ DisclaimerThis model is an independent analytical work and is provided for educational and portfolio demonstration purposes only. It is not intended as investment advice.The financial data used is based on publicly available information.This model is not affiliated with or endorsed by Juhayna Food Industries.Users are advised to conduct their own research and consult with qualified financial professionals before making any investment decisions.The author assumes no responsibility for any financial losses or decisions made based on this model.👤 AuthorMohamed MagdyFP&A AnalystMBA Candidate – Finance & InvestmentLinkedIn: linkedin.com/in/mohamed-magdy-financeGitHub: github.com/MohamedMagdy📄 LicenseThis project is licensed under the Creative Commons Attribution-NonCommercial 4.0 International License — see the LICENSE file for details.