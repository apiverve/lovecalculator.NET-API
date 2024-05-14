Love Calculator API
============

Love Calculator is a simple tool for calculating love compatibility. It returns the love compatibility percentage between two names.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Love Calculator API](https://apiverve.com/marketplace/api/lovecalculator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.LoveCalculator
```

Using the Package Manager:
```
nuget install APIVerve.API.LoveCalculator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.LoveCalculator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.LoveCalculator".
5. Click on the APIVerve.API.LoveCalculator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the lovecalculator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Love Calculator API documentation is found here: [https://docs.apiverve.com/api/lovecalculator](https://docs.apiverve.com/api/lovecalculator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Love Calculator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new LoveCalculatorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new QueryOptions {
  name1 = "John",
  name2 = "Jane"
};
```

###### Simple Request

```
var response = apiClient.execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    Console.WriteLine(response);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "name1": "Jane",
    "name2": "John",
    "lovePercentage": "62%",
    "response": "You have good chemistry. Keep exploring new connections and you might find something special.",
    "additionalText": "The love percentage between Jane and John is 62%."
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.