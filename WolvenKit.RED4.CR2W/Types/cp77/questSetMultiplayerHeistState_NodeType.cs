using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetMultiplayerHeistState_NodeType : questIMultiplayerHeistNodeType
	{
		private CEnum<questMultiplayerHeistState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questMultiplayerHeistState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<questMultiplayerHeistState>) CR2WTypeManager.Create("questMultiplayerHeistState", "state", cr2w, this);
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

		public questSetMultiplayerHeistState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
