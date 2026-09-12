# 13-Week Cash Management & Liquidity Forecast

### Excel-Based Treasury & FP&A Model for Short-Term Liquidity Planning

![Excel](https://img.shields.io/badge/Excel-13--Week%20Cash%20Forecast-217346?style=for-the-badge&logo=microsoft-excel&logoColor=white)
![FP&A](https://img.shields.io/badge/FP%26A-Treasury%20%26%20Liquidity-0A66C2?style=for-the-badge)
![Financial Modeling](https://img.shields.io/badge/Financial%20Modeling-Scenario%20Analysis-6F42C1?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Portfolio%20Project-orange?style=for-the-badge)

A practical Excel-based **13-week cash management and liquidity forecasting model** designed to support short-term Treasury, FP&A, working-capital, and funding decisions.

The model forecasts weekly cash inflows and outflows, identifies liquidity pressure points, calculates funding requirements, manages revolver capacity, and translates the forecast into actionable management insights.

---

## 📑 Table of Contents

- [Overview](#-overview)
- [Why a 13-Week Cash Forecast?](#-why-a-13-week-cash-forecast)
- [Business Questions Answered](#-business-questions-answered)
- [Key Features](#-key-features)
- [Workbook Structure](#-workbook-structure)
- [Model Data Flow](#-model-data-flow)
- [Key Liquidity Metrics](#-key-liquidity-metrics)
- [Core Model Logic](#-core-model-logic)
- [Scenario Framework](#-scenario-framework)
- [Liquidity Risk Framework](#-liquidity-risk-framework)
- [Example Management Insight](#-example-management-insight)
- [Recommended Management Actions](#-recommended-management-actions)
- [Controls & Validation](#-controls--validation)
- [Screenshots](#-screenshots)
- [How to Use](#-how-to-use)
- [Technical Notes & Publishing Warning](#-technical-notes--publishing-warning)
- [Repository Structure](#-repository-structure)
- [Skills Demonstrated](#-skills-demonstrated)
- [Intended Audience](#-intended-audience)
- [Disclaimer](#-disclaimer)
- [Author](#-author)
- [License](#-license)
- [Arabic Summary](#-arabic-summary)

---

## 📌 Overview

The **13-Week Cash Management & Liquidity Model** is designed for short-term liquidity planning and treasury decision-making.

Unlike an income-statement-focused model, this model concentrates on **cash availability, timing, funding needs, and borrowing capacity**.

It answers four fundamental questions:

1. How much cash is expected to come in each week?
2. How much cash is expected to go out?
3. When does the business fall below its minimum cash buffer?
4. How much external funding is required, and how much revolver capacity remains?

The model can be used as:

- A **13-week rolling cash forecast**
- An **early-warning liquidity tool**
- A **working-capital monitoring framework**
- A **revolver funding and capacity model**
- A **scenario analysis tool**
- An **Executive Liquidity Dashboard** for Treasury and FP&A review

---

## 🎯 Why a 13-Week Cash Forecast?

A 13-week cash forecast provides a detailed short-term view of liquidity and cash timing.

It helps management move beyond the question:

> "Is the business profitable?"

and focus on the treasury question:

> "Will the business have enough cash when it needs it?"

This distinction is particularly important because a business can report accounting profits while still experiencing short-term liquidity pressure due to:

- Delayed customer collections
- Large supplier payments
- Payroll and tax obligations
- Capital expenditure
- Debt service
- One-time cash outflows
- Financing constraints

The model therefore focuses on the **timing and availability of cash**.

---

## ❓ Business Questions Answered

| Treasury Question | Model Output |
| :--- | :--- |
| **Weekly cash inflows** | Cash sales + AR collections + other receipts |
| **Weekly cash outflows** | AP payments + payroll + taxes + CapEx + debt service + other payments |
| **Minimum cash breach** | Ending cash before financing vs. minimum cash buffer |
| **Funding requirement** | Weekly funding gap |
| **Revolver requirement** | Suggested revolver draw |
| **Facility capacity** | Revolver utilization and remaining headroom |
| **Liquidity runway** | Remaining headroom ÷ average weekly cash burn |
| **Peak liquidity pressure** | Maximum funding requirement and peak funding week |
| **Scenario sensitivity** | Comparison of Base, Conservative, and Stress cases |

---

## ⚙️ Key Features

**Cash Forecasting**
- 13-week direct cash forecast
- Weekly opening and ending cash balances
- Cash inflow and outflow analysis
- Net weekly cash movement

**Working Capital**
- Cash sales & credit sales
- AR collection timing (Current, 1-Week, 2-Week lag)
- AP payment timing (Current, 1-Week, 2-Week lag)
- Existing AR/AP balances management

**Operating Cash Outflows**
- Payroll, Taxes & Statutory payments
- Capital expenditure (CapEx)
- Debt service & Bank fees
- Cash transfers & Other financing outflows

**Financing & Liquidity**
- Minimum cash buffer control
- Funding-gap calculation
- Revolver draw logic
- Revolver repayment / cash sweep
- Revolver interest expense
- Facility utilization & Remaining borrowing capacity

**Risk & Management Analysis**
- Peak funding requirement
- Liquidity runway
- Revolver utilization risk
- Liquidity risk bands
- Automated controls
- Management insights
- Scenario analysis

---

## 🗂 Workbook Structure

| Sheet | Purpose |
| :--- | :--- |
| **Cover** | Model overview, navigation, and executive landing page |
| **Training Data** | Source assumptions, opening balances, scenario factors, and input checks |
| **Cash Inputs** | Weekly operating, working-capital, and financing assumptions |
| **Cash Forecast** | Core 13-week cash forecast, funding mechanics, and revolver schedule |
| **Liquidity Dashboard** | Executive liquidity KPIs, risk indicators, and management insights |
| **Dashboard Support** | Supporting calculations, chart data, thresholds, and dashboard logic |

The workbook is structured so that assumptions flow through the model without requiring users to manually rebuild calculations.

---

## 🔄 Model Data Flow

```text
Training Data
      │
      ▼
Cash Inputs
      │
      ▼
Cash Forecast
      │
      ├── Operating Cash Flow
      ├── Working Capital
      ├── Financing Cash Flow
      ├── Revolver Schedule
      └── Liquidity Controls
      │
      ▼
Liquidity Dashboard
      │
      ├── Key KPIs
      ├── Funding Requirement
      ├── Revolver Utilization
      ├── Liquidity Runway
      └── Risk & Management Insights