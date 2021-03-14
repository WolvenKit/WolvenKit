using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionEvent : redEvent
	{
		private wCHandle<gameObject> _hotspot;
		private wCHandle<gameObject> _activator;
		private CEnum<gameinteractionsEInteractionEventType> _eventType;
		private gameinteractionsLayerData _layerData;

		[Ordinal(0)] 
		[RED("hotspot")] 
		public wCHandle<gameObject> Hotspot
		{
			get
			{
				if (_hotspot == null)
				{
					_hotspot = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "hotspot", cr2w, this);
				}
				return _hotspot;
			}
			set
			{
				if (_hotspot == value)
				{
					return;
				}
				_hotspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get
			{
				if (_activator == null)
				{
					_activator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "activator", cr2w, this);
				}
				return _activator;
			}
			set
			{
				if (_activator == value)
				{
					return;
				}
				_activator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("eventType")] 
		public CEnum<gameinteractionsEInteractionEventType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<gameinteractionsEInteractionEventType>) CR2WTypeManager.Create("gameinteractionsEInteractionEventType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("layerData")] 
		public gameinteractionsLayerData LayerData
		{
			get
			{
				if (_layerData == null)
				{
					_layerData = (gameinteractionsLayerData) CR2WTypeManager.Create("gameinteractionsLayerData", "layerData", cr2w, this);
				}
				return _layerData;
			}
			set
			{
				if (_layerData == value)
				{
					return;
				}
				_layerData = value;
				PropertySet(this);
			}
		}

		public gameinteractionsInteractionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
