using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FrozenFrame : animAnimNode_OnePoseInput
	{
		private CInt32 _maxFramesFrozen;
		private CName _triggerEventName;
		private CName _clearEventName;

		[Ordinal(12)] 
		[RED("maxFramesFrozen")] 
		public CInt32 MaxFramesFrozen
		{
			get
			{
				if (_maxFramesFrozen == null)
				{
					_maxFramesFrozen = (CInt32) CR2WTypeManager.Create("Int32", "maxFramesFrozen", cr2w, this);
				}
				return _maxFramesFrozen;
			}
			set
			{
				if (_maxFramesFrozen == value)
				{
					return;
				}
				_maxFramesFrozen = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("triggerEventName")] 
		public CName TriggerEventName
		{
			get
			{
				if (_triggerEventName == null)
				{
					_triggerEventName = (CName) CR2WTypeManager.Create("CName", "triggerEventName", cr2w, this);
				}
				return _triggerEventName;
			}
			set
			{
				if (_triggerEventName == value)
				{
					return;
				}
				_triggerEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("clearEventName")] 
		public CName ClearEventName
		{
			get
			{
				if (_clearEventName == null)
				{
					_clearEventName = (CName) CR2WTypeManager.Create("CName", "clearEventName", cr2w, this);
				}
				return _clearEventName;
			}
			set
			{
				if (_clearEventName == value)
				{
					return;
				}
				_clearEventName = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FrozenFrame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
