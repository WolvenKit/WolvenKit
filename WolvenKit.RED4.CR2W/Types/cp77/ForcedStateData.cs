using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForcedStateData : CVariable
	{
		private CEnum<ECLSForcedState> _state;
		private CName _sourceName;
		private CEnum<EPriority> _priority;
		private CBool _savable;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ECLSForcedState>) CR2WTypeManager.Create("ECLSForcedState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CEnum<EPriority>) CR2WTypeManager.Create("EPriority", "priority", cr2w, this);
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

		[Ordinal(3)] 
		[RED("savable")] 
		public CBool Savable
		{
			get
			{
				if (_savable == null)
				{
					_savable = (CBool) CR2WTypeManager.Create("Bool", "savable", cr2w, this);
				}
				return _savable;
			}
			set
			{
				if (_savable == value)
				{
					return;
				}
				_savable = value;
				PropertySet(this);
			}
		}

		public ForcedStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
