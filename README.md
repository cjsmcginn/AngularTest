# AngularTest

**Overview**  
Your task will be to complete a simple master detail view using Angular, Angular Material, ASP.NET MVC, Web Api and Entity Framework. Certain items have been created to get you started. You should fork the AngularTest project into your own PUBLIC repository, so that it can be assesed when completed  
* A simple angular app
* An angular service for handling WebApi Rest calls, asyncDataService (async-data-service.js)
* An SQL server file database preloaded with data
* Constants with API Endpoints and locations of directive templates (constants.js)
* A LabOrderList WebApi controller for obtaining list view models
* A scaffolded LabOrder service for hanling requests between Api controllers, and the Database  

You will need to create the following items from scratch
* An Entity Framework model for the domain
* A Lab Order detail view WebApi controller
* A Lab Order detail view directive (and template)

When completed check in the application to your forked branch for review

**Tasks**  
* Create Entity Framework model using the existing database included in the project
* Create View Models that represent a Detail View, *The Master View Model representing Lab Order list items has already been completed for you* You will only need to create a View Model for the detail view.
* Implement the service method that fetches Lab Orders from the EF context, that returns a list of Lab Order list view models
* Create a detail view model, and corresponsing service method that fetches a detail view model of the selected lab order by Id. (See detail view attachment for fields that will need to be displayed)
* Create an API controller with a GET Method responsible for getting a Lab Order detail view model from the detail service method.
* Create an API Post method in the detail controller responsible for saving the Lab Order *Only the Amount Collected Property should be editable*
* In the master view a list view directive has been created for you. When a list item is clicked, the list should be hidden, and the detail view should be shown.
* Create a detail view directive. This directive should fetch a Lab Order Detail view model based on the id of the item clicked in the master directive control.
* The detail view should allow for the saving of a lab order *Only the amount collected should be editable*
* When the lab order is saved, the list view should initiate a refresh of data, and the detail view (directive) should be hidden, until another list item is selected

**Reference**
Below are images of the master and detail view. Generally, the finished application should look similar.

**List**
![alt text](https://raw.githubusercontent.com/cjsmcginn/AngularTest/master/AngularTest/Content/images/List.png)
**Detail**
![alt text](https://raw.githubusercontent.com/cjsmcginn/AngularTest/master/AngularTest/Content/images/detail.png)
