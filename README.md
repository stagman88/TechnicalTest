<img src="https://github.com/computerconquest/TechnicalTest/blob/master/techtestwelcome.svg" alt="We appreciate you taking the time to participate in our technical test.">

# The scenario

We have a client who has asked us to build a reporting portal for them. They specifically asked to be given information about their clients and how much income they get from each client.

We currently have a fairly basic C#/.Net core/WebApi/Entity Framework backend which provides a list of clients, products and sales history. A handful of endpoints have been included to supply some details about those.

Unfortunately, the client has since come to realise that a large amount of income from a client does not necessarily indicate that the client is highly profitable as there's a cost associated with each product. Some products are more profitable than others.

We would like a simple interface that makes it clearer which clients are the most profitable, so our client knows who to schmooze!

n.b. There may be issues with this application. You might need to fix things. There might be things that aren't best practices, so fix any major issues you spot, let us know anything else you see.

# Timebox

We'd like you to timebox this. Your time is important. We normally budget about an hour for this, but as this is a take home version, we can't set a time limit for you. Please! Anything more than a couple hours is probably excessive. We're not expecting a fully robust product with everything perfect. This is about achieving the objectives and finding a balance between doing so and fitting a budget (in this case the budget is the time dedicated to doing the task.)

# Installation

## Requirements

- NodeJS https://nodejs.org/en/
- DotNet 5 SDK https://dotnet.microsoft.com/download/dotnet/5.0
- Angular 11 CLI https://angular.io/cli
- Visual Studio Code (Or Visual Studio) https://code.visualstudio.com/

## Running

- Open a Terminal in VS Code

```
    cd ClientData
    npm install
    cd ..
    dotnet run
```

# Application Structure

## Backend

The backend is C# using WebApi and EntityFramework (an ORM which helps us translate between C# objects and relational databases). We use LINQ to create queries that are translated by Entity Framework into SQL.

We're using an in memory database for this, as it's easy to distribute. You can see where the data is seeded in DataGenerator.cs.

### Models

The models folder contains all of our models. You can think of these as representing tables in the database (because they do!).

This also includes any DTOs (Data Transfer Object) which we use to decouple the data we send to the frontend from our database schema. This allows us extra flexibility so we can pass the information the frontend needs without a lot of information it doesn't need. (e.g. calculated values)

### Controllers

The controllers folder contains all of our RESTful API endpoints. WebAPI handles the translation of HTTP calls to C# methods and C# method returns to HTTP responses. Each public method in our controllers represents an API endpoint that can be used to prepare data to send to the frontend.

## Client

All Client code is in the ClientApp folder. This is a normal Angular app, so code is under src/app

### Models

The models folder contains TypeScript matches for all of our C# models. In our real environments, these are auto-generated when the C# models are created or updated. In this example, we've kept it simple and you'll need to make sure any model changes you make are reflected in C# and in Typescript.

## Services

The services folder contains Angular services that represent all of our API endpoints. Again, in our real environments, we auto-generate these. However, in this case, if you modify the API you'll need to modify the Angular services as well.

## Home

This is a pretty simple app. We've only got one main component at the moment and that's the Home component. This is where you'll find the html/css/typescript related to what's displayed in the browser.

# What to do

- Get your environment up and running and send me a screenshot of it loaded up in your browser.
- Update the basic reporting portal using the supplied .Net/Angular framework (I know! It's very basic, but it should do the job!)
  - We want to know how much profit we're making from each client
  - The badges at the top were intended to display the top clients/products
  - What sort of user experience improvements would you make?
- Describe how the chart works. (No tricks here, just basics of how it figures out how tall the bars should be.)

Feel free to add any comments you want to the bottom of this or send it to us at the end.

# The results

This is a mix of practical (this is the sort of work you might be asked to do) as well as creative.

There's no right way or wrong way to do this.

Use whatever tools/Google-fu you'd normally use. Also, don't beat your head on your desk, feel free to mail us to ask questions. We use those questions to improve this document.

# When you're done

Zip everything up and send it to careers@ccqltd.com

Didn't finish everything? Send what you've done, 2 hours isn't a ton of time and we'd like to see what you did!

# Tips

- Start from the browser and work your way back. This is a great way to figure out how the app currently works.
- Be sure to use breakpoints. Breakpoints in your browser developer tools, breakpoints in VS code for any C# code.
- Almost all of the modifications we've asked for have very similar examples in place. You should be able to achieve nearly everything by copying/pasting and slightly modifying existing code.
- If you're not familiar with some of the technology and you're struggling with something, please remember to ask questions. We're not here to find out if you know about our specific stack, we're looking to see how you approach the problem.
