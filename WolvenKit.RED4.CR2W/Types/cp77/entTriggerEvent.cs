using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerEvent : redEvent
	{
		private entEntityID _triggerID;
		private entEntityGameInterface _activator;
		private Vector4 _worldPosition;
		private CUInt32 _numActivatorsInArea;
		private CUInt32 _activatorID;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("triggerID")] 
		public entEntityID TriggerID
		{
			get
			{
				if (_triggerID == null)
				{
					_triggerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "triggerID", cr2w, this);
				}
				return _triggerID;
			}
			set
			{
				if (_triggerID == value)
				{
					return;
				}
				_triggerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public entEntityGameInterface Activator
		{
			get
			{
				if (_activator == null)
				{
					_activator = (entEntityGameInterface) CR2WTypeManager.Create("entEntityGameInterface", "activator", cr2w, this);
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
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (Vector4) CR2WTypeManager.Create("Vector4", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numActivatorsInArea")] 
		public CUInt32 NumActivatorsInArea
		{
			get
			{
				if (_numActivatorsInArea == null)
				{
					_numActivatorsInArea = (CUInt32) CR2WTypeManager.Create("Uint32", "numActivatorsInArea", cr2w, this);
				}
				return _numActivatorsInArea;
			}
			set
			{
				if (_numActivatorsInArea == value)
				{
					return;
				}
				_numActivatorsInArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activatorID")] 
		public CUInt32 ActivatorID
		{
			get
			{
				if (_activatorID == null)
				{
					_activatorID = (CUInt32) CR2WTypeManager.Create("Uint32", "activatorID", cr2w, this);
				}
				return _activatorID;
			}
			set
			{
				if (_activatorID == value)
				{
					return;
				}
				_activatorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		public entTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
