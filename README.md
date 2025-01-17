# EventPlanner

The app folllows MVC rules

## Diagramme UML

Voici le diagramme UML de votre projet :

```mermaid
classDiagram
class Agent {
  -id: int
  -name: String
  -email: String
  -motDePasse: String
  -role : String
  +logIn()
  +createEvent()
  +modifyEvent()
  +deleteEvent()
  +deleteParticipant()
}
class Event {
  -id: int
  -name: String
  -date: DateTime
  -place: String
  -description: String
  -image: String
  -price: int
  -participants: List
}
class Participant {
  -id: int
  -name: String
  -age: int
  -phoneNumber: String
  -email: String
  -role : String
  +logIn()
  +signIn()
  +signInEvent()
}

class Statistiques {
  +countParticipants()
  +countParticipantsByAge()
}

Agent "1" --> "*" Event : create
Agent "1" --> "*" Event : modify
Agent "1" --> "*" Event : delete
Agent "1" --> "*" Participant : delete
Participant "1" --> "*" Event : signIn












