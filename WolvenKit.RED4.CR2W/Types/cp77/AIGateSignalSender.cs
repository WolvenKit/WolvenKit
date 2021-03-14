using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGateSignalSender : AIbehaviortaskStackScript
	{
		private CArray<CName> _tags;
		private CArray<CEnum<EAIGateSignalFlags>> _flags;
		private CFloat _priority;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public AIGateSignalSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
