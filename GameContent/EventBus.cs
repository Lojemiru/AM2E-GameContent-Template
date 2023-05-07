using System;

namespace GameContent;

/*
 * Event busses are simultaneously too specific and too simple in C# to warrant creating on the engine side.
 * Instead, they should be implemented within your own GameContent namespace.
 * 
 * This class is provided as a recommendation for the format you should follow, but is by no means necessary to use.
 * 
 * To add an event, you will need to declare the event itself, a default empty delegate, and a public wrapper with which
 * to trigger the event. You can declare this as follows:
 *
 * public static event Action OnExampleEvent = () => { };
 *
 * public static void ExampleEvent()
 * {
 *      OnExampleEvent();
 * }
 *
 * From here, you can subscribe/unsubscribe to the event as follows:
 *
 * EventBus.OnExampleEvent += MyCoolFunction;
 *
 * EventBus.OnExampleEvent -= MyCoolFunction;
 *
 * Please note: **ALL SUBSCRIPTIONS TO AN EVENT MUST BE MANUALLY REMOVED TO MAKE THE SUBSCRIBING OBJECT GARBAGE
 *      COLLECTABLE.** As far as I am aware, subscriptions count as a hard ref.
 * 
 * Triggering the event is also simple:
 * 
 * EventBus.ExampleEvent();
 *
 * For events that require arguments, you may use an Action<T> where T is the type/class utilized for your argument.
 *
 * Yes, this is kind of boilerplate-y. No, I haven't found a cleaner way to do this that doesn't completely violate the
 * flexibility or security of the event keyword. Please do inform me of my own ignorance if you know a better way :)
 */

public static class EventBus
{

}
