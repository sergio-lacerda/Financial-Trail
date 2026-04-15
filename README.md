![Financial Trail Logo](https://github.com/sergio-lacerda/Financial-Trail/blob/master/Preview/logo.png "Financial Trail Logo")

# Financial Trail - Indicators For Success

## 📊 Transforming Financial Data into Insights

Financial Trail is a sample financial data application designed to demonstrate how to consume data from a REST API and transform raw market data into meaningful indicators and visual insights.

The application allows users to input a stock ticker and explore processed financial data through charts and tables.

## 🌎 About the Project

Financial Trail is a practical example of consuming financial data from an external API, processing it and presenting it through tables, charts, and indicators.

## 🚀 Features

- 📊 Interactive financial charts using Google Charts
- 📈 Multiple stock market indicators
- 🔄 Real-time data consumption from external API
- 🧮 Data transformation using LINQ and Lambda Expressions
- 🌐 Clean and simple MVC architecture
- 💡 Focus on data processing and visualization
- 📊 Available Indicators

Given a stock ticker, the application fetches raw data from the Financial Modeling Prep API and processes it into structured financial insights:

- 📈 Intraday Indicators
  - Candlestick chart representing intraday price movements
- 💰 Dividends History
  - Table displaying the last 8 dividend payments (date and value)
- 📅 Dividends by Year
  - Column chart showing total dividends paid per year (last 10 years)
- 📉 Historical Prices
  - Line chart showing daily stock price variation over a selected period (typically 1 year)
- 📊 P/E Ratio vs Price (5 Years)
  - Combined chart:
    -Columns: yearly P/E ratio
    -Line: average stock price per year

## 🖼️ Screenshots
<br />

![Financial Trail Main Page](https://github.com/sergio-lacerda/Financial-Trail/blob/master/Preview/index.png "Financial Trail Main Page")

![Financial Trail Intraday Indicators](https://github.com/sergio-lacerda/Financial-Trail/blob/master/Preview/intraday.png "Financial Trail Intraday Indicators")

![Financial Trail Dividends](https://github.com/sergio-lacerda/Financial-Trail/blob/master/Preview/dividends.png "Financial Trail Dividends")

![Financial Trail Stock Historical Price](https://github.com/sergio-lacerda/Financial-Trail/blob/master/Preview/historical.png "Financial Trail Stock Historical Price")

![Financial Trail P/E Ratio](https://github.com/sergio-lacerda/Financial-Trail/blob/master/Preview/peratio.png "Financial Trail P/E Ratio")

<br />

## Technologies 

- .Net Core 7
- C#
- API REST
- MVC
- Linq
- Lambda Expressions
- HTML 5
- CSS 3 
- Bootstrap
- Bootstrap Icons ASP.Net Core
- Javascript / JQuery
- Google Charts

<br />

## Installation

Please, follow the instructions below in order to install and run this project:

    
### 1. Clone the repository

```console
git clone https://github.com/sergio-lacerda/Financial-Trail.git
```

   
### 2. Settings for the project

- **appsettings.json:** Edit the key "FMP_API_Key" and configure your personal API Key for the Financial Modeling Prep (FMP) API.

```json
"FMP_API_Key": "Your API Key goes here" 
```

   
### 3. How to obtain a personal API Key

All data used in this application project is sourced from the Financial Modeling Prep (FMP) API which is the sole owner of the financial data API and is responsible for the accuracy and reliability of the information provided through it.

In order to run this software, you'll be required to obtain your own Financial Modeling Prep (FMP) API Key. I encourage you to leverage the power of the Financial Modeling Prep (FMP) API also in your own projects.

It's easy to get started:

- Sign Up and choose a plan: Register on the FMP website and select a suitable plan that meets your requirements. Through this link, you can get 15% discount: :gift: [Get your API Key](https://intelligence.financialmodelingprep.com/pricing-plans?couponCode=sergio) :gift:
- Obtain API Key: Once you're subscribed, you'll receive your unique API key.
- With your API key in hand, you can integrate FMP's financial data into your applications, research, or projects to stay informed and up-to-date with the financial landscape.

<br />

## Usage instructions

- Financial Trail, is a sample Financial Data Application designed to showcase how to consume financial data a REST API and process these informations to generate tables, charts, and indicators related to the stock market.
- This is a non-commercial application, designed as an example only and to be used as is. This software is not designed for integrated use with any other solution, and there is no guarantee that the information will be available or that it will be compatible with users' specific needs.
