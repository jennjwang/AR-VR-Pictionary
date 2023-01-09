# AR/VR Pictionary

VR allows artsts to create drawings from
new perspectves with 3D brush strokes.
I created a multplayer game of pictonary
as a proof-of-concept for drawing in VR.
In this project, users experiment with a
collaboratve interface by creatng
drawings according to a given prompt
and guessing others’ drawings in real
tme. I then evaluated the efciency of
3D drawings as a form of communicaton
and surveyed confdence of both the
artsts and interpreters.

![](./vr.gif)

This game exempilifes a collaboratve interface which utlizes a
combination of complementary interaction methods to enable a co-located/remote collaboration among users. In AR/VR pictionary, users are able to observe each others' drawings with object synchronization and communicate through voice chat. The interface thereby infuences
users’ experiental aspects as a result of
their collectve actons.

Along with a VR interface, I implemented an AR spectator view where users can watch other players participate. AR combines real and virtual
content to enhance our understanding of the
physical environment. Given the availability of relatively affordable AR devices, including smartphones, AR offers more accessibility. However, it does not provide the
same level of immersion into an artfcial
environment as does VR.

![drawing of a unicorn](./arview.PNG?raw=true "AR View")

## Rules of the game
- There is a crayon in the middle of the room you can pick up to draw
- Whoever holds the crayon is the drawer, everyone else guesses what they are drawing
- The crayon holder should see a prompt appear on the screen and create a drawing according to that prompt
- The crayon holder has to release the crayon for others to draw


## Features
- You can press your left and right grasps to acquire the crayon
- Once you have the crayon, you can draw by pressing the right trigger (drawing only currently works for right hand)
- Once you have the crayon, you can see the prompt appear on the screen
- You should see others drawings
- You should see others holding the crayon
- You should be able to erase drawings by pressing the primary button
- You should be able to communicate through voice chat

## Tools
- Unity (AR Foundation, XR Interaction Toolkit)
- Normcore

