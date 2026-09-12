# Model Documentation

## 13-Week Cash Management & Liquidity Model

**Author:** Mohamed Yones
**Project Type:** Financial Modeling / Treasury / FP&A Portfolio Project
**Tool:** Microsoft Excel
**Model Horizon:** 13 Weeks

---

## 1. Model Overview

The **13-Week Cash Management & Liquidity Model** is a short-term treasury and FP&A model designed to forecast weekly cash movements, identify liquidity pressure points, determine external funding requirements, and monitor revolver capacity.

The model is built around a direct cash-flow forecasting approach and focuses on the relationship between:

* Operating cash inflows
* Working-capital collections and payments
* Operating and capital expenditures
* Financing activities
* Minimum cash requirements
* Revolver funding
* Liquidity headroom
* Cash-burn and runway

The objective is not only to calculate the expected cash balance, but also to translate the forecast into actionable liquidity insights for management.

---

## 2. Key Questions Answered

The model is designed to answer the following treasury questions:

1. **How much cash will the business have each week?**
2. **When does the business fall below its minimum cash buffer?**
3. **What is the peak funding requirement?**
4. **How much revolver funding is required?**
5. **How much borrowing capacity remains?**
6. **How heavily utilized is the revolver facility?**
7. **How many weeks of liquidity runway remain at the current cash-burn rate?**
8. **Which scenario creates the greatest liquidity pressure?**
9. **What management actions may be required to preserve liquidity?**

---

## 3. Model Architecture

The workbook follows a structured flow from assumptions to forecast outputs and management insights.

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
     ├── Financing Activity
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
     └── Risk Indicators
```

This structure separates **assumptions**, **calculation logic**, and **management outputs**, making the model easier to review, update, and audit.

---

## 4. Workbook Structure

| Sheet                   | Purpose                                                                            |
| ----------------------- | ---------------------------------------------------------------------------------- |
| **Cover**               | Executive landing page, model overview, and navigation                             |
| **Training Data**       | Source assumptions, scenario factors, opening balances, and input controls         |
| **Cash Inputs**         | Weekly operating, working-capital, and financing inputs                            |
| **Cash Forecast**       | Core 13-week cash forecast, funding requirements, revolver mechanics, and controls |
| **Liquidity Dashboard** | Executive-level liquidity KPIs, risk indicators, and management insights           |
| **Dashboard Support**   | Supporting calculations, chart ranges, thresholds, and dashboard logic             |

### Technical Note

A hidden technical worksheet named:

```text
__tracelight_scratchpad__
```

may exist in the working version of the workbook for technical purposes.

This worksheet should **not be included in the public GitHub release**. Before publishing the workbook, the technical sheet should be permanently removed and the model should be revalidated to confirm that all formulas, controls, and dashboard outputs continue to function correctly.

---

## 5. Scenario Framework

The model supports three predefined operating scenarios:

| Scenario         | Sales Factor | AR Collection Factor | AP Payment Factor | CapEx Factor |
| ---------------- | -----------: | -------------------: | ----------------: | -----------: |
| **Base**         |         1.00 |                 1.00 |              1.00 |         1.00 |
| **Conservative** |         0.95 |                 0.90 |              0.95 |         0.80 |
| **Stress**       |         0.85 |                 0.75 |              0.90 |         0.50 |

### Scenario Drivers

**Sales Factor**
Adjusts weekly sales billings relative to the base case.

**AR Collection Factor**
Adjusts the expected level of accounts receivable collections.

**AP Payment Factor**
Adjusts the expected level and timing of payments to suppliers.

**CapEx Factor**
Adjusts capital expenditure spending relative to the base case.

### Scenario Interpretation

The scenario framework should be interpreted as a **cash-management sensitivity framework**, rather than simply a revenue sensitivity analysis.

The Stress Case incorporates significant CapEx reduction, representing a management assumption that discretionary capital spending can be delayed or deferred in response to liquidity pressure.

This distinction is important because reducing CapEx and delaying supplier payments can temporarily improve liquidity even when sales and collections weaken.

---

## 6. Operating Cash Flow Logic

### 6.1 Cash Sales

Cash sales are calculated based on weekly sales billings and the percentage collected immediately in cash.

```text
Cash Sales = Adjusted Sales Billings × Cash Sales %
```

---

### 6.2 Accounts Receivable Collections

Credit sales are collected according to defined timing assumptions.

The collection profile contains:

1. Existing AR collections
2. Current-week credit collections
3. One-week lag collections
4. Two-week lag collections

```text
Total AR Collections
=
Existing AR Collections
+
Current Week Credit Collections
+
1-Week Lag Collections
+
2-Week Lag Collections
```

The collection percentages across the current-week and lag buckets should reconcile to 100% of the applicable credit-sales collection profile.

---

### 6.3 Other Receipts

Other receipts represent miscellaneous cash inflows that are entered directly as weekly assumptions.

---

## 7. Cash Outflow Logic

### 7.1 Accounts Payable Payments

Supplier payments are modeled using a timing-based payment profile consisting of:

1. Existing AP payments
2. Current-week payments
3. One-week lag payments
4. Two-week lag payments

```text
Total AP Payments
=
Existing AP Payments
+
Current Week AP Payments
+
1-Week Lag AP Payments
+
2-Week Lag AP Payments
```

This structure allows management to evaluate the liquidity effect of changing supplier-payment behavior.

---

### 7.2 Other Operating Outflows

The model includes the following major cash outflows:

* Payroll
* Taxes and statutory payments
* Capital expenditures
* Debt service
* Other operating payments
* Bank fees
* Cash transfers
* Other financing outflows

These items are modeled on a weekly basis to reflect the short-term nature of treasury planning.

---

## 8. Cash Forecast Logic

The core forecast follows a weekly cash roll-forward.

```text
Ending Cash Before Financing
=
Opening Cash
+
Total Cash Inflows
-
Total Cash Outflows
+
Finance & Treasury Cash Flow
```

The resulting balance is evaluated against the minimum cash buffer.

The model therefore distinguishes between:

**Cash before financing**

and

**Cash after financing**

This distinction is critical because a business can experience a liquidity deficit operationally while remaining funded through a revolving credit facility.

---

## 9. Minimum Cash Buffer

The model maintains a predefined minimum cash balance designed to protect operating liquidity.

```text
Minimum Cash Buffer
=
Required minimum cash balance
```

When cash before financing falls below this threshold, the model calculates the funding requirement necessary to restore the minimum liquidity level.

---

## 10. Funding Requirement

The weekly funding requirement is calculated as:

```text
Funding Need
=
MAX(
0,
Minimum Cash Buffer − Ending Cash Before Financing
)
```

This ensures that the model does not generate unnecessary funding when the business already maintains sufficient cash.

The model also identifies the **Peak Funding Requirement**, representing the highest funding need during the 13-week forecast period.

---

## 11. Revolver Funding Mechanics

The revolving credit facility is used as the primary external liquidity source.

### Suggested Revolver Draw

```text
Suggested Revolver Draw
=
MIN(
Funding Need,
Remaining Facility Headroom
)
```

This prevents the model from drawing more debt than the available facility capacity.

### Revolver Headroom

```text
Remaining Revolver Headroom
=
Revolver Facility Limit − Ending Revolver Balance
```

A zero or negative headroom figure indicates that the facility is fully utilized or exceeded and requires immediate management attention.

---

## 12. Revolver Repayment and Cash Sweep

When sufficient cash is available above the minimum buffer, excess liquidity may be used to repay outstanding revolver borrowings.

```text
Cash Available for Sweep
=
MAX(
0,
Cash Available − Minimum Cash Buffer
)
```

The repayment is constrained by the outstanding revolver balance.

```text
Debt Repayment
=
MIN(
Planned Repayment + Cash Sweep,
Opening Revolver Balance
)
```

This approach allows the model to simulate both liquidity draws and potential debt paydown.

---

## 13. Revolver Interest Expense

Interest expense is calculated using the opening revolver balance and the annual revolver interest rate.

```text
Interest Expense
=
Opening Revolver Balance
×
(Revolver APR ÷ 52)
```

The model uses a 52-week convention to translate the annual interest rate into a weekly rate.

---

# 14. Liquidity Runway Analysis

Liquidity runway represents the estimated number of weeks for which the remaining unused revolver capacity can support the current level of cash burn.

### Remaining Headroom

```text
Remaining Headroom
=
Facility Limit − Ending Revolver Balance
```

### Average Weekly Cash Burn

The model calculates the average weekly cash burn during the post-peak funding period.

Conceptually:

```text
Average Weekly Cash Burn
=
ABS(
AVERAGE(
Weekly Net Cash Movement after Peak Funding
)
)
```

### Liquidity Runway

```text
Liquidity Runway (Weeks)
=
Remaining Revolver Headroom
÷
Average Weekly Cash Burn
```

A higher runway indicates greater liquidity protection, while a low runway indicates that available borrowing capacity could be exhausted quickly if the current cash-burn pattern continues.

### Important Interpretation

Liquidity runway is a **forward-looking liquidity indicator**, not a formal solvency measure.

It assumes that:

* Current cash-burn behavior continues
* Revolver capacity remains available
* No major refinancing occurs
* No material improvement or deterioration occurs outside the modeled assumptions

Therefore, runway should always be interpreted together with the cash forecast and scenario analysis.

---

## 15. Liquidity Risk Framework

### Liquidity Runway

|        Runway | Status | Interpretation                             |
| ------------: | ------ | ------------------------------------------ |
| **> 6 weeks** | GREEN  | Strong liquidity cushion                   |
| **3–6 weeks** | AMBER  | Liquidity should be actively monitored     |
| **< 3 weeks** | RED    | Immediate liquidity action may be required |

### Revolver Utilization

|     Utilization | Status        | Interpretation                          |
| --------------: | ------------- | --------------------------------------- |
|       **< 60%** | GREEN         | Comfortable facility capacity           |
| **60% – < 80%** | AMBER         | Elevated reliance on external liquidity |
|       **≥ 80%** | RED / WARNING | Limited remaining borrowing capacity    |

These thresholds are configurable and should be adjusted according to the company's liquidity policy and risk appetite.

---

## 16. Management Liquidity Indicators

The dashboard should highlight the following key indicators:

| KPI                             | Purpose                                              |
| ------------------------------- | ---------------------------------------------------- |
| **Opening Cash**                | Starting liquidity position                          |
| **Minimum Cash Buffer**         | Required operating cash floor                        |
| **Peak Funding Required**       | Maximum external funding requirement                 |
| **Peak Funding Week**           | Timing of maximum liquidity pressure                 |
| **Ending Revolver Balance**     | Total outstanding revolver exposure                  |
| **Revolver Utilization %**      | Percentage of facility currently used                |
| **Remaining Revolver Headroom** | Available unused borrowing capacity                  |
| **Average Weekly Cash Burn**    | Current rate of liquidity consumption                |
| **Liquidity Runway**            | Estimated weeks until available headroom is consumed |
| **Control Status**              | Overall model/control condition                      |

---

## 17. Model Controls & Validation

The model contains automated controls designed to validate the integrity of key calculations.

| Control                   | Logic                                                    | Purpose                               |
| ------------------------- | -------------------------------------------------------- | ------------------------------------- |
| **Cash Roll-Forward**     | Opening Cash + Net Movement = Ending Cash                | Confirms cash reconciliation          |
| **Revolver Roll-Forward** | Opening Balance + Draw − Repayment = Closing Balance     | Confirms debt reconciliation          |
| **Facility Capacity**     | Closing Revolver ≤ Facility Limit                        | Prevents over-borrowing               |
| **AR Roll-Forward**       | Opening AR + Credit Sales − Collections = Closing AR     | Validates receivables logic           |
| **AP Roll-Forward**       | Opening AP + Purchases − Payments = Closing AP           | Validates payables logic              |
| **Minimum Cash Control**  | Ending Cash maintained at required level after financing | Identifies liquidity shortfalls       |
| **Input Quality Checks**  | Scenario and assumption validation                       | Prevents incomplete or invalid inputs |

All controls should return an acceptable status such as:

```text
OK
PASS
```

Any exception should be investigated before management relies on the forecast.

---

## 18. Model Usage

### Step 1 — Update Assumptions

Open the **Training Data** sheet and update the designated input cells.

Typical inputs include:

* Selected scenario
* Opening cash
* Opening AR
* Opening AP
* Minimum cash buffer
* Revolver facility limit
* Revolver interest rate
* Weekly operating assumptions

---

### Step 2 — Validate Inputs

Review the input quality checks and confirm that all required inputs are valid.

---

### Step 3 — Select Scenario

Choose one of:

```text
Base
Conservative
Stress
```

The selected scenario should flow dynamically through the forecast.

---

### Step 4 — Review Cash Forecast

Use the **Cash Forecast** sheet to analyze:

* Weekly cash inflows
* Weekly cash outflows
* Net cash movement
* Funding requirements
* Revolver draws
* Revolver repayments
* Ending cash

---

### Step 5 — Review Liquidity Dashboard

The dashboard should be used to identify:

* Peak liquidity pressure
* Revolver utilization
* Remaining headroom
* Liquidity runway
* Risk status
* Potential management actions

---

## 19. Key Model Insights

Under the current Conservative scenario, the model indicates a significant liquidity pressure point during the middle of the forecast.

The current modeled profile shows:

* **Peak funding requirement:** approximately **$2.09M in Week 6**
* **Ending revolver balance:** approximately **$8.11M**
* **Revolver utilization:** approximately **81%**
* **Remaining headroom:** approximately **$1.89M**
* **Ending cash after financing:** maintained around the **$1.00M minimum cash buffer**
* **Post-Week-6 cash generation:** remains structurally negative, increasing dependence on the revolver

### Management Interpretation

The model is technically funded under the current assumptions, but liquidity is **tight rather than comfortable**.

The combination of high revolver utilization and continued weekly cash burn means that available borrowing capacity could be consumed relatively quickly if the current trend persists.

This highlights the importance of monitoring:

* Weekly cash burn
* Customer collections
* Supplier payment timing
* Capital expenditure commitments
* Revolver availability
* Minimum cash requirements

---

## 20. Management Actions Supported by the Model

The model can support short-term treasury decisions such as:

### Working Capital

Accelerate customer collections and review overdue receivables.

### Supplier Payments

Evaluate whether supplier payment timing can be optimized without damaging critical supplier relationships.

### Capital Expenditure

Prioritize essential CapEx and defer discretionary projects where appropriate.

### Financing

Monitor revolver availability and proactively evaluate additional financing before the facility approaches maximum utilization.

### Cash Preservation

Protect the minimum operating cash buffer and avoid discretionary cash outflows during periods of elevated liquidity pressure.

---

## 21. Key Assumptions & Limitations

The model is an illustrative portfolio model and contains several simplifying assumptions.

### Forecast Horizon

The model covers 13 weeks and is intended for short-term liquidity management rather than long-range financial planning.

### Working Capital

AR and AP collection/payment timing is based on predefined assumptions rather than customer- or supplier-level aging schedules.

### Existing AR/AP

Existing AR and AP inputs are subject to the model's opening-balance and timing assumptions. Further expansion would be required for a detailed sub-ledger-based roll-forward.

### Scenario Design

Scenario factors are synthetic and intended to demonstrate the impact of operating assumptions on liquidity.

### Financing

The model assumes a single revolving credit facility with a fixed annual interest rate.

### Interest Convention

Interest is estimated using a 52-week year and the opening revolver balance.

### Cash Burn

Liquidity runway is based on historical/projected cash-burn behavior within the model horizon and should not be interpreted as a guaranteed future outcome.

---

## 22. Model Design Philosophy

The model follows several principles commonly used in treasury and FP&A modeling:

**Transparency**
Inputs, assumptions, calculations, and outputs are logically separated.

**Traceability**
Key management metrics can be traced back to weekly forecast drivers.

**Scenario Flexibility**
Different operating environments can be evaluated without rebuilding the model.

**Liquidity Focus**
The model emphasizes cash availability and funding capacity rather than accounting profit alone.

**Management Relevance**
Outputs are designed to support practical decisions around cash preservation, borrowing, and working capital.

---

## 23. Disclaimer

This project is an **educational and portfolio financial-modeling exercise**.

All assumptions, scenarios, transactions, and financial figures are illustrative and synthetic. The model should not be interpreted as investment advice, lending advice, financial advice, or a representation of an actual company's financial position.

---

## 24. Author

**Mohamed Yones**

Financial Modeling | FP&A | Treasury & Liquidity Analysis

**Core Skills:**

Excel | Cash Forecasting | Treasury | Working Capital | Scenario Analysis | Liquidity Management | Financial Modeling
