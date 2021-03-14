using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocoState : animAnimNode_State
	{
		private CEnum<animLocoStateType> _type;
		private CName _locoTag;

		[Ordinal(17)] 
		[RED("type")] 
		public CEnum<animLocoStateType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<animLocoStateType>) CR2WTypeManager.Create("animLocoStateType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("locoTag")] 
		public CName LocoTag
		{
			get
			{
				if (_locoTag == null)
				{
					_locoTag = (CName) CR2WTypeManager.Create("CName", "locoTag", cr2w, this);
				}
				return _locoTag;
			}
			set
			{
				if (_locoTag == value)
				{
					return;
				}
				_locoTag = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LocoState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
