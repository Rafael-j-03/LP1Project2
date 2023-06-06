# Project 2 of "Linguagens de Programação 1"

### Objective of the Project:

Implement a game calledd "Tragic: The Reckoning" in the form of application in console in C# 8.0/.NET 6.0. Using MVC (model view controller)

## Authored by

- [@Rafael-j-03](https://github.com/Rafael-j-03) - Rafael José - 22202078
- [@rodrigogomes01](https://github.com/rodrigogomes01) - Rodrigo Gomes - 22201252

## How our project was made

- The code production was done by Rafael José with the help of Rodrigo Gomes in making the README.md document development in which Rafael José helped with explaining in some technical aspects for a better understanding of the document.

- 1st commit - Added .gitignore and LP1Project1 solution; - Rafael José - 22202078

- 2nd commit - Added project 'Tragic'; - Rafael José - 22202078

- 3rd commit - Added template class Player where it's determined the HP, MP and the player's Deck; - Rafael José - 22202078

- 4th commit - Added the template class Controller with player 1 and player2; - Rafael José - 22202078

- 5th commit - Added template class View and interface IView; - Rafael José - 22202078

- 6th commit -  Added MVC template to the class Program, create a controller with two players, a view with a controller and start game; - Rafael José - 22202078

- 7th commit - Add interface Card for the cards with card name, card attack point, card cost, card defense points, and quantity available; - Rafael José - 22202078

- 8th commit - Added card FlyingWand with its attributes; - Rafael José - 22202078

- 9th commit - Added card Severed Monkey with its attributes; - Rafael José - 22202078

- 10th commit - Added a class to generate a Deck and show it on screen; - Rafael José - 22202078

- 11th commit - Added more types of cards and its attributes; - Rafael José - 22202078

- 12th commit - Added class Hand to deal with the current cards, removing and adding cards; - Rafael José - 22202078

- 13th commit - Add main loop template that goes by each phase of the play and initial attributes; - Rafael José - 22202078

- 14th commit - Add SpellPhase for each player; - Rafael José - 22202078

- 15th commit - Added option to skip turn if the player doesn't select a card; - Rafael José - 22202078

- 16th commit - Added SelectedCards and CombatPhase template to identify which cards were selected by the players and remove them from the current hand; - Rafael José - 22202078

- 17th commit - Changed the mode that the player is named; - Rafael José - 22202078

- 18th commit - Added XML comments to all the current code; - Rafael José - 22202078

- 19th commit - Updated README.md; - Rodrigo Gomes - 22201252

[Git Repository](https://github.com/Rafael-j-03/LP1Project2)

## Development of our work

- Started by creating the project in our git repository which we used to communicate and develop our project;

- Interpret the project's statement and with that we started our code by the templates for the Player class as well as the Controller class to call the players first;

- Created the View class for identifying the phase where the player selects the card or not and if the choice is valid according to the attributes;

- From here we added the MVC to the Program to start organizing our project this way;

- Determided each attributed for the cards in the cards class using an interface;

- From this point we started adding every card sepperately that will be playable;

- Started generating the deck at this point by addig the class hand, this will remove and add cards from the player's hand during their respective plays;

- Added the main loop to the game that adds MP to the players 1 for each round 2 for 2 rounds etc.;

- Added spell phase for each playee checking if the selected card is valid and the player has enough MP to play it;

- Also added a method to skip the turn.

## UML file
![UML](./uml.png)

## References

- We searched on the web for #GetExecutingAssembly" on StackOverflow and we clarified some doubts with code suggested by ChatGPT.
