# Tower-Tumble
Tower Tumble for Team Double 11 (Team 11) Game Design 5970

A description of current progress, plans, and format here.
Currently a level is made of a couple key components. First: launcher. This should launch ball prefabs towards blocks and plushies. Blocks act as structures/obstacles. Plushies are the objective, and can be collected by any collision. A level manager is used to handle the majority of the score, UI, winning/losing etc. Basically defining the level. 

Level manager set up <br>
Given how critical it is to get right, I want to outline level manager in particular
```
shotText: corresponds to the shot count at the top left of the screen
winText: corresponds to the win text at the center of the screen
plushText: corresponds to the remaining plush count at the top right of the screen
plushCount: number of plushies in the level. *automatically collected as long as plushies are tagged "Plushie"
shotCount: number of shots in the level. When reduced to 0, no additional shots should occur, and a timer starts. If plushies are not collected within 5 seconds, the level is lost.
lost: I honestly forgot, I will adjust this later. Think that was for preventing weird coroutine edge cases, unsure. Regardless, hopefully shouldn't need adjustment
```
To set this up for a new level, set up UI elements and set the appropriate shot count. Make sure the level manager is named "Level Manager" EXACTLY. Otherwise launcher and plushie scripts will not recognize it. 
