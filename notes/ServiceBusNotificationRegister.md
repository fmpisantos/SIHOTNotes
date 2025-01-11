# Servicebus notification register
There should be a new way to register the notifications that will be processed by the service bus for each of the channel managers.

## Registation
### UI
A new tab in the edit popup should be displayed "Notifications".
This tab should display:
- Table with the already registered notifications
- Space to add new notification (if there are any notification types that are supported by the servicebus but not yet "activated" for this channel manager):
    - Combobox for the available to register comboboxes:
        - Comboboxes that the service bus supports
        - Minus notifications that are already in the listbox
    - Combobox that only appears if the first combobox has a value selected and that value has different triggers
- Add button that only displays if both comboboxes have a value selected or if the 1st combobox has a value and the second doesnt exist because theres just one trigger

### List of available notifications
The list of notifications should be defined in the servicebus in a way that we can simply had the notification and possible available triggers. 
This shall be used to process any notification that is present in the list, at the moment this is hard coded for the availability notifications

<!-- ## Making it reusable by other notification types -->
<!-- Can this be reused by other notification types? -->

### Idea 1:
Create a new "handler" that can be extended by each of the notificationsTypes

#### Base class
The base class has a AcknowledgeNotification(string notificationBody), this class:
- Method that given the notificationBody can get the type of notification
- Instanciated the right handler given the type of notification
- Has a common AckowledgeNotification Method that by default:
    - Checks if the hotel and notificaiton type is enabled
    - If not returns the right S_xxx_PUSH_VXXXResponse
    - Calls the children class Process method
    - Handles the catch(Exception) case
    - Sends the correct Response in case of success

#### Children classes
- Implement the Process method
- Has a responseType and a stringType to be used by the base class

#### Get available type of notifications
```csharp
// Find all child classes of BaseClass
var childClasses = Assembly.GetExecutingAssembly()
                           .GetTypes()
                           .Where(t => t.IsSubclassOf(typeof(BaseClass)));

// Call the static method in each child class
foreach (var childClass in childClasses)
{
    // Get the StaticMethod() MethodInfo
    var staticMethod = childClass.GetMethod("StaticMethod", BindingFlags.Public | BindingFlags.Static);
    if (staticMethod != null)
    {
        // Invoke the static method if found and save it to a list that can be used by the client to display the available types of notifications
        staticMethod.Invoke(null, null);
    }
}
```

### Save enabled by used notifications in DB
We need to store the enabled notification pushes.
This is necessary just to display on the new availableNotifications screen, since the notifications will be set and removed bu notification_register and notification_unregistry. 
