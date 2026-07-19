# 🏢 Juhayna Food Industries (EGX: JUFO) — Enterprise Financial Model

[![Excel](https://img.shields.io/badge/Microsoft_Excel-217346?style=for-the-badge&logo=microsoft-excel&logoColor=white)](https://www.microsoft.com/en-us/microsoft-365/excel)
[![Version](https://img.shields.io/badge/version-1.0.0-blue.svg)](https://github.com/MohamedMagdy/Juhayna-Financial-Model)
[![License: CC BY-NC 4.0](https://img.shields.io/badge/License-CC%20BY--NC%204.0-lightgrey.svg)](https://creativecommons.org/licenses/by-nc/4.0/)
[![GitHub stars](https://img.shields.io/github/stars/MohamedMagdy/Juhayna-Financial-Model?style=social)](https://github.com/MohamedMagdy/Juhayna-Financial-Model/stargazers)

> **An enterprise-grade, fully audited 3-statement financial model for Juhayna Food Industries (EGX: JUFO), featuring a dynamic dashboard, scenario manager, and 70+ automated integrity checks.**

---

## 📖 Table of Contents

- [Overview](#-overview)
- [Key Statistics](#-key-statistics)
- [Enterprise Design Principles](#-enterprise-design-principles)
- [Key Features](#-key-features)
- [Model Architecture & Workflow](#-model-architecture--workflow)
- [Screenshots](#-screenshots)
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

Built using **industry-standard enterprise FP&A and financial modeling best practices**, the model features a clean 5‑layer architecture, a **Single Source of Truth (SSoT)** reporting layer, and over **70 automated validation checks** to ensure data integrity and auditability. It is designed to be fully transparent, scalable, and ready for Power BI integration.

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

This model is built on a set of core design principles that reflect enterprise-grade financial modeling standards:

| Principle | Description |
|:----------|:------------|
| **Single Source of Truth (SSoT)** | All downstream outputs source data exclusively from the Reporting Layer. |
| **No Hardcoded KPIs** | All KPIs are calculated dynamically via the KPI Engine. |
| **Fully Auditable** | Every value is traceable to its source via the Reporting Layer's `Source Sheet`, `Source Cell`, and `Lineage Path` columns. |
| **Governance First** | A dedicated Control Panel with 70+ automated integrity checks continuously validates the model. |
| **Dynamic Scenario Engine** | 5 pre-built scenarios flex key drivers with side‑by‑side comparison and dashboard impact analysis. |
| **Zero Circular References** | The model is structurally free of circular references. |
| **Power BI Integration Ready** | A flat‑table export (`tbl_PBI_Export`) is included for seamless BI ingestion. |
| **Formula Registry & Documentation** | All named ranges (370+) are cataloged in the Model Registry; a full Formula Governance ledger tracks exceptions. |
| **Data Lineage & Transparency** | Full documentation ensures every assumption and calculation is transparent and reviewable. |

---

## ✨ Key Features

### 🚀 Executive Dashboard
- Interactive dashboard with dynamic KPIs, charts, and a model health indicator.
- Year (2022–2026), Scenario, and Currency (EGP/USD) selectors for real‑time analysis.
- 5‑year trend visualization with sparklines and YoY variance indicators.

### 📈 3‑Statement Financials
- Fully integrated **Income Statement, Balance Sheet, and Cash Flow** statements.
- Historical (2016–2024) + Forecast (2025–2026) periods.
- Automated cross‑sheet reconciliations: **Balance Check, Cash Tie, Net Income Tie** (tolerance < 0.05).

### ⚙️ KPI Engine & Reporting Layer
- Centralized calculation engine with 49+ KPIs for consistency and auditability.
- **Single Source of Truth (SSoT)** layer with full data lineage columns:
  - `Source Sheet`
  - `Source Cell`
  - `Lineage Path`
- Ensures all downstream outputs (Dashboard, Charts, Sensitivity) read from the SSoT.

### 🎯 Scenario & Sensitivity Analysis
- 5 pre‑built scenarios (Base, Optimistic, Conservative, Stress, Custom) with custom overrides.
- Advanced sensitivity toolkit:
  - **Tornado Analysis** – 7 assumptions flexed ±10%.
  - **One‑Way Sensitivity** – Revenue growth → Net Income waterfall.
  - **Two‑Way Sensitivity** – Revenue growth × EBITDA margin heat map.
  - **Break‑even Analysis** – Revenue required for NI = 0 with margin of safety.
- Dynamic Scenario Manager with side‑by‑side scenario comparison.

### 🛡️ Enterprise Governance
- **Control Panel** – 70+ automated integrity checks with 5‑tier severity (Critical/High/Medium/Low/Information).
- **Audit Trail** – Full change log with date, user, sheet, cell, old/new values, change type, reason, and approver.
- **Formula Governance** – Exception ledger tracking all formula deviations (32 entries, 0 Critical/High).
- **Model Registry** – Catalog of 370+ named ranges with metadata (type, source, description, used by, owner, criticality).

### 📦 Power BI Integration Ready
- Dedicated flat‑table export sheet: `📊 Power BI Export`.
- Native Excel table `tbl_PBI_Export` with 16 KPIs and 5‑year history.
- Clean, numeric‑only structure (DQ‑05 check ensures zero text in export).

### 📡 Market Data Hub
- Dual‑mode operation: **LIVE** (via S&P Capital IQ add‑in) or **MANUAL** (user overrides).
- Data validation, quality scoring, and status monitoring.
- Falls back gracefully to manual values when the LIVE feed is unavailable.

---

## 🧠 Model Architecture & Workflow

The model follows a strict **5‑layer enterprise architecture** to ensure robustness, scalability, and auditability.

### Data Flow Workflow
