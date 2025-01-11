# Average team velocity/Throughput (delivered tasks):
- Calculate the amount of planned effort that was completed within a sprint/we need to have a fix sprint time or adjust the calculation
- Adjust per user so that when are calculating the amount of work that could be achieved in the sprint per team we can have into account who is working because the production is not always the same
- We should also save the impact of someone being off, per instance Im think that the production of the sprint will fall if p.e. Sven you are off on vacations. So in that case we should plan accordingly 
- Maybe I'm wrong on that but with time the excepted planned time is an average of all the past sprints so it will only get better/ more accurate.
We could also take out the most extreme cases of sprints to help with the average

# Burndown chart

## Filters
- Team
- User
- Statusi-team
- By scope changes (tasks added in the middle of the sprinot)

Planned and unplanned
NTasks, Remaining effort estimated effort

### Data needed for filters:
- Group working times put per day in each sprint
	- Save them by user or team
- Save tasks in sprint by day (maybe just number of tasks) this will help to see the "injection" of new tasks during the sprint and see their impact
	- We have the planned effort for each task so we can calculate the estimated effort and display on the graph this as a guide line 
		- We need to know when the effort for a task is changed "by day and amount", this includes tasks added to the sprint mid sprint
		- We need to mark the changes that happen in each day to the planned time, so we can identify if the change in the graph was made by a new task being added or a miss estimation 
		of the task effort
## Data gathering
This informatino can be obtain by the task history, but the calculations will take a long time maybe.
- Therefor the information must be stored by day the same way we save the tages statistics
- In the start of the sprint we calculate the ideal effort per day (simple division)
- If it takes 2 long to calculate we might want to calculate it in the background for the old sprints
	- Since the worst part will be to fill the statistical data

Date ntasks
status
	team
	user
	empty
efforts
	estimated
		team
		user
		empty
	actual
		team
		user
		empty
