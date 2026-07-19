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
  - [Executive Dashboard](#-executive-dashboard)
  - [3-Statement Financials](#-3-statement-financials)
  - [KPI Engine & Reporting Layer](#-kpi-engine--reporting-layer)
  - [Scenario & Sensitivity Analysis](#-scenario--sensitivity-analysis)
  - [Enterprise Governance](#-enterprise-governance)
  - [Power BI Integration](#-power-bi-integration)
  - [Market Data Hub](#-market-data-hub)
- [Model Architecture & Workflow](#-model-architecture--workflow)
- [Screenshots](#-screenshots)
  - [1. Professional Cover Page](#1-professional-cover-page)
  - [2. Executive Dashboard](#2-executive-dashboard)
  - [3. KPI Engine](#3-kpi-engine)
  - [4. Reporting Layer (Single Source of Truth)](#4-reporting-layer-single-source-of-truth)
  - [5. Scenario Manager](#5-scenario-manager)
  - [6. Sensitivity Analysis](#6-sensitivity-analysis)
  - [7. Market Data Hub](#7-market-data-hub)
  - [8. Control Panel](#8-control-panel)
  - [9. Model Architecture (Dependency Map)](#9-model-architecture-dependency-map)
  - [10. Audit Trail](#10-audit-trail)
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

Built using **industry-standard enterprise FP&A and financial modeling best practices**, the model features a clean 5‑layer architecture, a **Single Source of Truth (SSoT)** reporting layer, and over **70 automated validation checks** to ensure data integrity and auditability.

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

Interactive dashboard with dynamic KPIs, charts, and a model health indicator. Features Year (2022–2026), Scenario, and Currency (EGP/USD) selectors for real‑time analysis with 5‑year trend visualization.

### 📈 3‑Statement Financials

Fully integrated **Income Statement, Balance Sheet, and Cash Flow** statements with Historical (2016–2024) + Forecast (2025–2026) periods. Automated cross‑sheet reconciliations: **Balance Check, Cash Tie, Net Income Tie** (tolerance < 0.05).

### ⚙️ KPI Engine & Reporting Layer

Centralized calculation engine with 49+ KPIs for consistency and auditability. The **Single Source of Truth (SSoT)** layer includes full data lineage columns: `Source Sheet`, `Source Cell`, and `Lineage Path` — ensuring all downstream outputs read from the SSoT.

### 🎯 Scenario & Sensitivity Analysis

5 pre‑built scenarios (Base, Optimistic, Conservative, Stress, Custom) with custom overrides. Advanced sensitivity toolkit includes **Tornado Analysis**, **One‑Way Sensitivity**, **Two‑Way Sensitivity Heat Map**, and **Break‑even Analysis** with margin of safety.

### 🛡️ Enterprise Governance

- **Control Panel** – 70+ automated integrity checks with 5‑tier severity.
- **Audit Trail** – Full change log with approval workflow.
- **Formula Governance** – Exception ledger (32 entries, 0 Critical/High).
- **Model Registry** – Catalog of 370+ named ranges with metadata.

### 📦 Power BI Integration

Dedicated flat‑table export (`tbl_PBI_Export`) with 16 KPIs and 5‑year history. Clean, numeric‑only structure (DQ‑05 check ensures zero text in export).

### 📡 Market Data Hub

Dual‑mode operation: **LIVE** (via S&P Capital IQ) or **MANUAL** (user overrides). Features data validation, quality scoring, and graceful fallback to manual values when LIVE feed is unavailable.

---

## 🧠 Model Architecture & Workflow

The model follows a strict **5‑layer enterprise architecture** to ensure robustness, scalability, and auditability.

### Data Flow Workflow
