using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectSignalEvent : redEvent
	{
		private TweakDBID _statusEffectID;
		private CFloat _priority;
		private CArray<CName> _tags;
		private CArray<CEnum<EAIGateSignalFlags>> _flags;
		private CFloat _repeatSignalDelay;

		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get
			{
				if (_statusEffectID == null)
				{
					_statusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectID", cr2w, this);
				}
				return _statusEffectID;
			}
			set
			{
				if (_statusEffectID == value)
				{
					return;
				}
				_statusEffectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CFloat) CR2WTypeManager.Create("Float", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CArray<CEnum<EAIGateSignalFlags>> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CArray<CEnum<EAIGateSignalFlags>>) CR2WTypeManager.Create("array:EAIGateSignalFlags", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("repeatSignalDelay")] 
		public CFloat RepeatSignalDelay
		{
			get
			{
				if (_repeatSignalDelay == null)
				{
					_repeatSignalDelay = (CFloat) CR2WTypeManager.Create("Float", "repeatSignalDelay", cr2w, this);
				}
				return _repeatSignalDelay;
			}
			set
			{
				if (_repeatSignalDelay == value)
				{
					return;
				}
				_repeatSignalDelay = value;
				PropertySet(this);
			}
		}

		public StatusEffectSignalEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
