// Feature: Postion
//     Output a postion

// @acceptance
// Scenario Outline: Return Current Postion
//     Simple example of how to test move

//     Given the character starts at position with XCoordinates <startingPositionX>
//     And starts at YCoordinates <startingPositionY>
//     And the player chooses to move in <direction>
//     And the current move count is <startingMoveCount>
//     When the character moves
//     Then the character is now at position with XCoordinates <endingPositionX>
//     And YCoordinates  <endingPositionY>
//     And the new move count is <endingMoveCount>
//     Examples:

// | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
// | 5 | 5 | NORTH | 0 | 5 | 6 | 1 |
// | 5 | 6 | EAST | 1 | 6 | 6 | 2 |
// | 6 | 6 | EAST | 2 | 7 | 6 | 3 | 
// | 7 | 6 | EAST | 3 | 8 | 6 | 4 |
// | 8 | 6 | EAST | 4 | 9 | 6 | 5 |
// | 9 | 6 | EAST | 5 | 9 | 6 | 6 | 
// | 9 | 6 | SOUTH | 6 | 9 | 5 | 7 | 
// | 9 | 5 | SOUTH | 7 | 9 | 4 | 8 | 
// | 9 | 4 | WEST | 8 | 8 | 4 | 9 | 
// | 8 | 4 | WEST | 9 | 7 | 4 | 10 | 