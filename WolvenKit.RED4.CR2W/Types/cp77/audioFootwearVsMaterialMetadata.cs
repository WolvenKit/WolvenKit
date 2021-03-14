using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootwearVsMaterialMetadata : audioAudioMetadata
	{
		private CName _footwearType;
		private CName _skidEvent;
		private CName _defaultFootstep;
		private CHandle<audioLocomotionStateEventDictionary> _locomotionStates;
		private CHandle<audioLocomotionCustomActionEventDictionary> _customActionEvents;

		[Ordinal(1)] 
		[RED("footwearType")] 
		public CName FootwearType
		{
			get
			{
				if (_footwearType == null)
				{
					_footwearType = (CName) CR2WTypeManager.Create("CName", "footwearType", cr2w, this);
				}
				return _footwearType;
			}
			set
			{
				if (_footwearType == value)
				{
					return;
				}
				_footwearType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skidEvent")] 
		public CName SkidEvent
		{
			get
			{
				if (_skidEvent == null)
				{
					_skidEvent = (CName) CR2WTypeManager.Create("CName", "skidEvent", cr2w, this);
				}
				return _skidEvent;
			}
			set
			{
				if (_skidEvent == value)
				{
					return;
				}
				_skidEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultFootstep")] 
		public CName DefaultFootstep
		{
			get
			{
				if (_defaultFootstep == null)
				{
					_defaultFootstep = (CName) CR2WTypeManager.Create("CName", "defaultFootstep", cr2w, this);
				}
				return _defaultFootstep;
			}
			set
			{
				if (_defaultFootstep == value)
				{
					return;
				}
				_defaultFootstep = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("locomotionStates")] 
		public CHandle<audioLocomotionStateEventDictionary> LocomotionStates
		{
			get
			{
				if (_locomotionStates == null)
				{
					_locomotionStates = (CHandle<audioLocomotionStateEventDictionary>) CR2WTypeManager.Create("handle:audioLocomotionStateEventDictionary", "locomotionStates", cr2w, this);
				}
				return _locomotionStates;
			}
			set
			{
				if (_locomotionStates == value)
				{
					return;
				}
				_locomotionStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("customActionEvents")] 
		public CHandle<audioLocomotionCustomActionEventDictionary> CustomActionEvents
		{
			get
			{
				if (_customActionEvents == null)
				{
					_customActionEvents = (CHandle<audioLocomotionCustomActionEventDictionary>) CR2WTypeManager.Create("handle:audioLocomotionCustomActionEventDictionary", "customActionEvents", cr2w, this);
				}
				return _customActionEvents;
			}
			set
			{
				if (_customActionEvents == value)
				{
					return;
				}
				_customActionEvents = value;
				PropertySet(this);
			}
		}

		public audioFootwearVsMaterialMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
