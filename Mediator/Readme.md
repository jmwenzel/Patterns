# Mediator

> Mediator Design Pattern falls under **Behavioral Pattern** of Gang of Four (GOF) Design Patterns in .Net. 
> Any pattern that is a Behavioral Pattern is concerned with how classes and objects interact and distribute responsibility.

## Definition

The mediator pattern defines an object which encapsulates how a set of objects interact with each other.
It promotes loose coupling by keeping objects from referring to each other explicitly, and it allows their interaction to be varied independently. So what this means is that objects will pass messages to the mediator, who will pass it on to the right object handler.

You can think of a Mediator object as a traffic control tower. Pilots of the planes approaching or departing the terminal area communicate with the tower rather than explicitly communicating with one another.

## Structure

 - **Mediator** defines an interface for communicating with Collegue objects
 - **ConcreteMediator** classes implement behavior to coordinate Colleague objects. Each ConcreteMediator knows what its constituent Colleague classes are.
 - **Colleague** defines an interface for concrete colleague objects. This could also be an abstract class with a field that holds a reference to a mediator.
 - **ConcreteColleagueA/B** classes communicate with each other via the mediator.

## Implementation

Let’s look at an example with a console application in .NET Core. We have a chat room, a user will send a message to the mediator and this object will be in charge of communicating to other members within the chat room.
