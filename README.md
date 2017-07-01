# NightAtTheMuseum
Project 5 - Udacity VR Nanodegree
By: Mike Boyer

Task List:
1) Create the following scenes, using images saved to Google Drive for textures:
X	A) Gaming Industry : Mostly complete, requires some extra features (video play control, etc.) 29 JUN 17
	B) VR/AR CAD
	C) Movie Theaters/Occulus Room App
	D) AR Specific Applications
	E) Medical / Systems Training
	F) Credits / Exit Room
	
2) Develop/Find/Convert to *.ogv and *.mp4 videos for the following subjects:
	A) Serious Sam VR Gameplay
	B) Keep Talking and Nobody Explodes VR
	C) Rec Room Multiplayer VR
	D) AR Hololens Applications : Have, just need to convert
	E) VR/AR CAD 
	F) Medical / Systems Training
	
3) Develop Scripts for:
	A) Credits room - implement the X of X script from the maze project
	B) Exiting Game
X	C) Storing data between scenes (objects collected/areas visited) : Done 1 JUL
	D) Collecting objects/enabling videos
	E) Monster/Sprite Gun on Camera 
	F) Switching rooms / keeping scores
X	G) Floor - based navigation : Ground Raycasting added 27 JUN 17
	H) Video Playing on Reticle Click

4) Develop Canvas Objects for:
	A) Exhibit Start
	B) Exhibit Credits

5) Develop animations for:
X	A) Key Floating : Done 29 JUN 17
	B) Monster attack

6) Find sounds for:
	A) Game room - growling sounds
	B) Game room - background music
	
7) Screenshots for:
	A) Game room - Elite Dangerous
	B) Game room - Rick and Morty
	
1 JUL 17 - Built the main scene, importing free assets from unity store (Industrial Textures - Arkham Interactive).
Added script to change between levels. Need to implement artifact collection (done), video unlocking, and counting (done). Once this
is complete, I will finish gathering videos and add the remaining scenes. Last but not least should be the special feature
I have planned for the Game Industry scene (3E).
	
29 JUN 17 - I decided to work on adding the blue key. I wanted it to change height similar to project 3, but also rotate quickly.
After some playing around, I realized a simple transform.rotate and transform.position line was all I needed. Ended up with a pretty
nice animation. I've also fixed the autoplay and pointer control functions for the movie screen prefab. Now, I just need to have it
check to see if the artifact is collected before the player can play.

27 JUN 17 -  I need to be better about updating this file. I've managed to work out Ground Raycasting via the Udacity-supplied
content from Project 4 studies. Next, I plan to gather assets for the other rooms. At this time, I still need to record game video
and locate content for some of the other rooms. I plan to use the key from Project 3 with an animation to rotate it. I also need
to import my homemade script for scores, and determine how to maintain scores between levels. This is a bit out of scope for this 
project, but is useful for future projects. Also, I love the game Accounting, but I just got Rick and Morty VR on sale, and will
be recording screenshots from that, instead. I bet it will be more polished/complete, given its a paid-for game.

23 JUN 17 -
After some trial and error (and of course following instructions), I think I've finally figured out the GitHub Desktop
and Unity issues I was having. Additionally, last night I decided to go with the Occulus VR sdk for video streaming
in this project. I'm also adding the task list for tracking purposes.

22 JUN 17 - 
Having some issues committing all the unity files for backup via GitHub Desktop and Unity with these instructions:
http://www.studica.com/blog/how-to-setup-github-with-unity-step-by-step-instructions

