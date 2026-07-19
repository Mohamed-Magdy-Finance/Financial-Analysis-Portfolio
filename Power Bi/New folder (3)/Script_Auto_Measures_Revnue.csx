// ============================================================
// Tabular Editor Advanced Script — Revenue & Profitability Dashboard
// Rebuilt using the REAL source schema (confirmed from the raw Excel data):
// Table "Data": Retailer, Retailer ID, Date, Region, State,
//               Beverage Brand, Price per Unit, Units Sold, Revenue, Expenses
// 3,725 rows | Full year 2022
// ============================================================
// HOW TO USE: External Tools -> Tabular Editor -> Advanced Scripting -> paste -> Run (F5)
// Then in Power BI Desktop: accept refresh prompt -> Ctrl+S
// ============================================================

var t = Model.Tables["Data"];

// --- Executive basics ---
t.AddMeasure("Total Revenue", "SUM('Data'[Revenue])", "#,##0");
t.AddMeasure("Total Expenses", "SUM('Data'[Expenses])", "#,##0");
t.AddMeasure("Profit", "[Total Revenue] - [Total Expenses]", "#,##0");
t.AddMeasure("Profit Margin %", "DIVIDE([Profit], [Total Revenue])", "0.0%");

t.AddMeasure("Last Refresh Date",
    "\"Last updated: \" & FORMAT(TODAY(), \"dd mmm yyyy\")", "");

t.AddMeasure("Dynamic Title",
    "\"Revenue Overview — \" & SELECTEDVALUE('Data'[Beverage Brand], \"All Brands\")", "");

// --- Target & variance ---
t.AddMeasure("Target Margin", "0.79", "0%")
    .Description = "Set at the current portfolio average (79%) — adjust to your real board target.";

t.AddMeasure("Variance vs Target", "[Profit Margin %] - [Target Margin]", "0.0%;-0.0%");

t.AddMeasure("Profitability Tier",
    "SWITCH(TRUE(),\n" +
    "    [Profit Margin %] >= [Target Margin] + 0.01, \"Outperforming\",\n" +
    "    [Profit Margin %] >= [Target Margin] - 0.01, \"On Target\",\n" +
    "    \"Underperforming\")", "");

// --- Concentration & risk (customer/retailer dependency) ---
t.AddMeasure("Retailer Revenue Contribution %",
    "DIVIDE([Total Revenue], CALCULATE([Total Revenue], ALL('Data'[Retailer])))", "0.0%");

t.AddMeasure("Retailer Concentration Index (HHI)",
    "SUMX(\n" +
    "    ALL('Data'[Retailer]),\n" +
    "    DIVIDE(CALCULATE([Total Revenue]), CALCULATE([Total Revenue], ALL('Data'[Retailer]))) ^ 2\n" +
    ") * 10000", "0")
    .Description = "HHI on retailer revenue. >2500 = dangerous single-customer dependency (portfolio currently ~2900 -> Sodapop alone is ~46% of revenue).";

t.AddMeasure("Brand Revenue Rank", "RANKX(ALL('Data'[Beverage Brand]), [Total Revenue])", "0");
t.AddMeasure("Brand Margin Rank", "RANKX(ALL('Data'[Beverage Brand]), [Profit Margin %])", "0");

// --- Seasonality (real finding: Jul peak, Mar trough) ---
t.AddMeasure("Seasonality Index",
    "DIVIDE([Total Revenue], CALCULATE([Total Revenue], ALL('Data'[Date])) / 12)", "0.00")
    .Description = "1.0 = average month. >1 = above-average season (Jul/Dec), <1 = below-average (Feb/Mar). Use for inventory & promo planning.";

// --- Price/volume relationship ---
t.AddMeasure("Avg Price per Unit", "AVERAGE('Data'[Price per Unit])", "$#,##0.00");
t.AddMeasure("Total Units Sold", "SUM('Data'[Units Sold])", "#,##0");
t.AddMeasure("Revenue per Unit", "DIVIDE([Total Revenue], [Total Units Sold])", "$#,##0.00");

Info("Done! 16 measures added to table 'Data' using the confirmed real schema. Save back to Power BI Desktop.");
