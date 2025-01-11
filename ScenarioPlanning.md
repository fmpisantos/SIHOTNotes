# Scenary planning
	- plan reservation and see how it will be at the end if you accept diferent scenarios
	- front office can create event reservation
		- Link FO reservation
		- Create FO reservation
			- Connet reservation with event 
	- In sakuba every reservation is connected to Event
	- registry syncs some fields ex: "reservationType" thats why you can only change it on the Event reservation
	- when you copy 
		- alternitive -> both are connected but in the future only one will be used (only the event are linked, not the res)
		- serial create more than one "one time", "montly" -> chained
		- last nothing in common
	- reservation type request, when you change to garanteed it checks if event linked and cancels the others
	
	- diferent front office reservations and meal plans, 8 of them can be canceled when garanteing the right event to be used
	
	- all created from sihot360
	
	- find the best occupancy
	
	## Scenario:
		- Entry point: needs a master file
		- Then scenario planning dialog
		- t3 -> Category rack
			- free rooms, occupied rooms
			- requirement:
				-show vacantRooms occupiedRooms
		- t2 has planned FO reservations and garanteed FO reservations as well
		- cannot plan from diferent events if they are alternative to each other

	# Requirements
		- Planning front office reservations because planing is only on front office reservations
		- show vacantRooms/occupiedRooms

	Whwn applying plan reservations will get new type and new category (set in registry)

fillingbeds?

# Activate
	- Class=PARANOIA,Value=enableScenarioPlanning
	- Class=scenarioPlanning
		- 910554

# APL
	- scenarioHeader is 
	- Singleton is being used

# Tables
	- header => master file
	- detail = connected to header => connected reservation that I planned = moving from left to right in the planning
	- resgroupheader => Comments is in the deatil since it is removed when moving from left to right they would disapear, this should fix it (only created when it is needed, when some one saves a comment)


lockedCollumns

registry to choose if the person type is shown in the popup or as it is at the moment

use the virtual one ? until you have the real new comment
