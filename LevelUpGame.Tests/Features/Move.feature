Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
        | 1 | 1 | NORTH | 0 | 1 | 1 | 1 |
        | 1 | 1 | WEST | 0 | 1 | 1 | 1 |
        | 1 | 1 | EAST | 0 | 2 | 1 | 1 |
        | 1 | 1 | SOUTH | 0 | 1 | 2 | 1 |
        | 9 | 8 | NORTH | 31 | 9 | 7 | 32 |
        | 10 | 3 | WEST | 14 | 9 | 3 | 15 |
        | 1 | 1 | SOUTH | 3 | 1 | 2 | 4 |
        | 9 | 6 | WEST | 6 | 8 | 6 | 7 |
        | 10 | 1 | EAST | 21 | 10 | 1 | 22 |
        | 10 | 10 | EAST | 14 | 10 | 10 | 15 |
        | 10 | 10 | SOUTH | 21 | 10 | 10 | 22 |
        | 1 | 10 | WEST | 6 | 1 | 10 | 7 |
        | 6 | 7 | EAST | 67 | 7 | 7 | 68 |
        | 6 | 10 | EAST | 61 | 6 | 10 | 62 |
        | 1 | 3 | WEST | 16 | 1 | 3 | 17 |
        | 3 | 1 | NORTH | 21 | 3 | 1 | 22 |  