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

## 🧱 Architecture

This project follows a standard ASP.NET Core MVC architecture, focusing on clarity and separation of concerns rather than complexity.

- Controllers handle user inputs (stock ticker) and requests
- Model manages communication with the external API (FMP)
- Data processing is performed using LINQ and Lambda Expressions
- Views render charts and tables using Google Charts

## 🛠️ Technologies 

### Backend

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

- **.NET Core 7** using **MVC** architecture.
- **REST API** development.
- Queries with **LINQ & Lambda Expressions**.

### Frontend
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

- **UI/UX:** Responsive design with **Bootstrap** and **Bootstrap Icons**.
- **Interactivity:** DOM manipulation using **JavaScript** and **jQuery**.
- **Dashboards:** Financial data visualization with **Google Charts**.

## ⚙️ Installation

Please, follow the steps below to run the project locally:
    
### 1. Clone the repository

```console
git clone https://github.com/sergio-lacerda/Financial-Trail.git
```
   
### 2. Settings for the project

- Edit the **appsettings.json** file and set your Financial Modeling Prep (FMP) API key.

```json
"FMP_API_Key": "Your API Key goes here" 
```
   
### 3. 🔑 How to Obtain an API Key

All financial data used in this project is provided by the Financial Modeling Prep (FMP) API.

To use the application, you need your own API key:

- Sign up on the FMP website and choose a plan  [Get your API Key](https://intelligence.financialmodelingprep.com/pricing-plans)
- Receive your personal API key
- Add it to the project configuration as described above

### 4. Run the project
Open the solution file (.sln) in Visual Studio and press F5 or click "Run".

## 🎯 Use Cases

This project is useful for:

- Learning how to consume REST APIs in .NET
- Practicing data transformation with LINQ
- Building financial dashboards
- Understanding how to turn raw data into visual insights
- Demonstrating full-stack development skills in a portfolio

## ⚠️ Disclaimer

This is a non-commercial sample application intended for educational purposes only.

- Not intended for production use
- No guarantee of data accuracy
- Not designed for integration with other systems

All financial data is owned and provided by Financial Modeling Prep (FMP).


## 🤝 Contributing

Feel free to:

- Fork this repository
- Open issues
- Submit pull requests
- ⭐ Support

If you find this project useful, consider giving it a star on GitHub!

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
