# PlayerManagerMVC

## UML Diagram

```mermaid
classDiagram
    class Player {
        +string Name
        +int Score
        +void UpdateScore(int)
    }

    class Model {
        +List~Player~ Players
        +void AddPlayer(Player)
        +void RemovePlayer(Player)
        +Player FindPlayer(string)
    }

    class Controller {
        +PlayerManager manager
        +void AddNewPlayer(string)
        +void UpdatePlayerScore(string, int)
    }
    class View {
        +void ShowMenu()
        +void DisplayPlayers(IEnumerable<Player> playersToList)
        +Player (string name, int score) GetNewPlayerInfo()
        +int GetMinimumScore()
        +PlayerOrder GetSortOrder()
        +void WaitForKey()
        +void DisplayGoodbye()
        +void DisplayError(string message)
    }
Controller --> Model
Controller --> View
Model --> Player