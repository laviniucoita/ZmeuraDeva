# ZmeuraDeva
ASPNET CORE website project for a bussiness who sales fresh and natural grown berries. ZmeuraDeva is a fresh company on the fruits market in Romania promising a lot of value to the market 

## Getting Started


These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.
- Clone the project to your local working environment
```
git clone [link]
```
- Enter ZmeuraDeva working directory
```
cd ZmeuraDeva
```
- Run the dotnet embeded kestrel server software to run the hole project locally
```
dotnet run
```
- If you change something in the js/css/html/cs files and do not automaticaly propragate restart the kestrel software
```
Ctrl + C
dotne run
```

### Prerequisites

What things you need to install the software and how to install them
SendGrid additional package needs to be installed. Open Cmd and run

```
dotnet add package SendGrid
```


### Installing

A step by step series of examples that tell you how to get a development env running

.NET Core 2.2 SDK installer needs to be installed in order to run this project. Download link below

```
https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.300-windows-x64-installer
```



You will have success running the application when the following messages appear in cmd

```
Now listening on: https://localhost:5001
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

## Development and Structure

The project is Based on Razor Pages. Please visit this website to understand the structure of the application 

```
https://www.learnrazorpages.com/
```

Main ideea behind is that for each page in the website there is a Model file and View file
For example: The contact page in the application has the following files
```
Contact.cshtml
Contact.cshtml.cs
```

.cshtml - contorls the view of the page (How the user will see the content)
.cshtml.cs - controls the model of the page (back-end what user will not see)

The same goes for index and galerie pages

In order to make a simple management of the html elements there is a general Layout file that is inherited from on each of the mentioned files earlier

```
Pages/Share/_Layout.cshtml
```

Js/CS/Bootstrap4/Jquery/Magnify/Static content are stored in the wwwroot folder 

Visit each one of them to modify the elements

## Using

1. Bootstrap4 


## Authors

* **G. Cristian** 
* **C. Laviniu** 

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments


