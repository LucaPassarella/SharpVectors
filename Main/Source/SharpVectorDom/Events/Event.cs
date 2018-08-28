using System;

namespace SharpVectors.Dom.Events
{
	/// <summary>
	/// Summary description for Event.
	/// </summary>
	public class Event : IEvent
	{
		#region Private Fields
		
		internal bool _stopped;
		internal IEventTarget _eventTarget;
		internal IEventTarget _currentTarget;
		internal EventPhase _eventPhase;
		
		private bool _bubbles;
		private DateTime _timeStamp;
		private bool _cancelable;
		private string _namespaceUri;
		protected string _eventType;
		
		#endregion
		
		#region Constructors
		
		public Event()
		{
            _eventPhase = EventPhase.AtTarget;
            _timeStamp  = DateTime.Now;
        }
		
		public Event(string eventType, bool bubbles, bool cancelable)
            : this()
		{
			InitEvent(eventType, bubbles, cancelable);
		}
		
		public Event(string namespaceUri, string eventType, bool bubbles, bool cancelable)
            : this()
        {
            InitEventNs(namespaceUri, eventType, bubbles, cancelable);
		}
		
		#endregion
		
		#region Properties
		
		#region DOM Level 2
		
		public string Type
		{
			get
			{
				return _eventType;
			}
		}
		
		public IEventTarget Target
		{
			get
			{
				return _eventTarget;
			}
		}
		
		public IEventTarget CurrentTarget
		{
			get
			{
				return _currentTarget;
			}
		}
		
		public EventPhase EventPhase
		{
			get
			{
				return _eventPhase;
			}
		}
		
		public bool Bubbles
		{
			get
			{
				return _bubbles;
			}
		}
		
		public bool Cancelable
		{
			get
			{
				return _cancelable;
			}
		}
		
		public DateTime TimeStamp
		{
			get
			{
				return _timeStamp;
			}
		}
		
		#endregion
		
		#region DOM Level 3 Experimental
		
		public string NamespaceUri
		{
			get
			{
				return _namespaceUri;
			}
		}
		
		public bool IsCustom
		{
			get
			{
				throw new NotImplementedException();
			}
		}
		
		public bool IsDefaultPrevented
		{
			get
			{
				throw new NotImplementedException();
			}
		}
		
		#endregion
		
		#endregion
		
		#region Methods
		
		#region DOM Level 2
		
		public void StopPropagation()
		{
			throw new NotImplementedException();
		}
		
		public void PreventDefault()
		{
			throw new NotImplementedException();
		}
		
		public void InitEvent(string eventType, bool bubbles, bool cancelable)
		{
			_namespaceUri = null;
			_eventType    = eventType;
			_bubbles      = bubbles;
			_cancelable   = cancelable;
		}
		
		#endregion
		
		#region DOM Level 3 Experimental
		
		public void InitEventNs(string namespaceUri, string eventType, bool bubbles, bool cancelable)
		{
			_namespaceUri = namespaceUri == "" ? null : namespaceUri;
			_eventType    = eventType;
			_bubbles      = bubbles;
			_cancelable   = cancelable;
		}
		
		public void StopImmediatePropagation()
		{
			throw new NotImplementedException();
		}
		
		#endregion
		
		#endregion
	}
}
