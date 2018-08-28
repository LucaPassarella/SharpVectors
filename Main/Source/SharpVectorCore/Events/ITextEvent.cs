using SharpVectors.Dom.Views;

namespace SharpVectors.Dom.Events
{
	/// <summary>
	/// The <see cref="ITextEvent">ITextEvent</see> interface provides
	/// specific contextual information associated with Text Events.
	/// </summary>
	/// <remarks>
	/// Note: To create an instance of the
	/// <see cref="ITextEvent">ITextEvent</see> interface, use the
	/// feature string <c>"TextEvent"</c> as the value of the input parameter
	/// used with the
	/// <see cref="IDocumentEvent.CreateEvent">IDocumentEvent.CreateEvent</see>
	/// method.
	/// </remarks>
	public interface ITextEvent : IUiEvent
	{
		/// <summary>
		/// <see cref="Data">Data</see> holds the value of the characters
		/// generated by the character device. This may be a single
		/// Unicode character or it may be a string.
		/// </summary>
		string Data
		{
			get;
		}
		
		/// <summary>
		/// The <see cref="InitTextEvent">InitTextEvent</see> method is used
		/// to initialize the value of a
		/// <see cref="ITextEvent">ITextEvent</see> created using the
		/// <see cref="IDocumentEvent.CreateEvent">IDocumentEvent.CreateEvent</see>
		/// method.
		/// </summary>
		/// <remarks>
		/// This method may only be called before the
		/// <see cref="ITextEvent">ITextEvent</see> has been dispatched via
		/// the
		/// <see cref="IEventTarget.DispatchEvent">IEventTarget.DispatchEvent</see>
		/// method, though it may be called multiple times during that phase
		/// if necessary. If called multiple times, the final invocation takes
		/// precedence. This method has no effect if called after the event
		/// has been dispatched.
		/// </remarks>
		/// <param name="typeArg">
		/// Specifies the event type.
		/// </param>
		/// <param name="canBubbleArg">
		/// Specifies whether or not the event can bubble. This parameter
		/// overrides the intrinsic bubbling behavior of the event.
		/// </param>
		/// <param name="cancelableArg">
		/// Specifies whether or not the event's default action can be
		/// prevent. This parameter overrides the intrinsic cancelable
		/// behavior of the event.
		/// </param>
		/// <param name="viewArg">
		/// Specifies the <see cref="ITextEvent">TextEvent</see>'s view.
		/// </param>
		/// <param name="dataArg">
		/// Specifies the <see cref="ITextEvent">TextEvent</see>'s data
		/// attribute.
		/// </param>
		void InitTextEvent(string typeArg, bool canBubbleArg, bool cancelableArg,
			IAbstractView viewArg, string dataArg);
		
		/// <summary>
		/// The <see cref="InitTextEventNs">InitTextEventNs</see> method is
		/// used to initialize the value of a
		/// <see cref="ITextEvent">ITextEvent</see> created using the
		/// <see cref="IDocumentEvent.CreateEvent">IDocumentEvent.CreateEvent</see>
		/// method. This method may only be called before the
		/// <see cref="ITextEvent">ITextEvent</see> has been dispatched via
		/// the
		/// <see cref="IEventTarget.DispatchEvent">IEventTarget.DispatchEvent</see>
		/// method, though it may be called multiple times during that phase
		/// if necessary. If called multiple times, the final invocation takes
		/// precedence. This method has no effect if called after the event
		/// has been dispatched. 
		/// </summary>
		/// <param name="namespaceUri">
		/// Specifies the
		/// <see href="http://www.w3.org/TR/2003/WD-DOM-Level-3-Events-20030331/glossary.html#dt-namespaceURI">namespace URI</see>
		/// associated with this event, or <c>null</c> if the applications
		/// wish to have no namespace.
		/// </param>
		/// <param name="type">
		/// Specifies the event type.
		/// </param>
		/// <param name="canBubbleArg">
		/// Specifies whether or not the event can bubble.
		/// </param>
		/// <param name="cancelableArg">
		/// Specifies whether or not the event's default action can be
		/// prevent.
		/// </param>
		/// <param name="viewArg">
		/// Specifies the <see cref="ITextEvent">ITextEvent</see>'s view.
		/// </param>
		/// <param name="dataArg">
		/// Specifies the <see cref="ITextEvent">ITextEvent</see>'s data
		/// attribute
		/// </param>
		void InitTextEventNs(string namespaceUri, string type, bool canBubbleArg,
			bool cancelableArg, IAbstractView viewArg, string dataArg);
	}
}
