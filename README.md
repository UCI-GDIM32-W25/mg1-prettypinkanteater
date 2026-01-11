[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# MG1
## Devlog
Audrey Hu, she/her

The plan I wrote in the MG1 break-down activity connects to the code I wrote by primarily breaking down the scripts attached to the player and EventSystem game objects. Specifically, it detailed the requirement of a planting function for the player whenever space was pressed which in the player class and script attached to the player game object was the PlantSeed() method. Inside the planting method, I used the Instantiate() method that was additionally mentioned in the break-down to make a plant appear. I did not go into further depth on the use of if then statements in the break-down itself. There was also the need for player movement, which I also did not elaborate furhter on in the break-down but this and the planting was all contained by the Update() method, which was listed in the plan so that movement and planting were checked for in every frame.

Additionally, my group and I mentioned the member variables of the player class that would track the amount of seeds both planted and in possession. Although I did not declare these variables myself, I did use them in the planting method for decrementing and incrementing count.

As for the EventSystem, we mentioned the need for a method to update the text tracking seeds planted and remaining. This became the UpdateSeeds() method in the Plant Count UI class and script that was attached to the game object and did as detailed by accessing the text member variable of the referenced UI text game objects. We also mentioned that the method should be called by the player whenever a plant was instantiated. This is reflected in my code because I call the method in the planting method in my player class.
## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

