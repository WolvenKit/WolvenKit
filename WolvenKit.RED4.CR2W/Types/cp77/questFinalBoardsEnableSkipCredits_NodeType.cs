using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsEnableSkipCredits_NodeType : questIUIManagerNodeType
	{
		private CBool _enableSkipping;

		[Ordinal(0)] 
		[RED("enableSkipping")] 
		public CBool EnableSkipping
		{
			get
			{
				if (_enableSkipping == null)
				{
					_enableSkipping = (CBool) CR2WTypeManager.Create("Bool", "enableSkipping", cr2w, this);
				}
				return _enableSkipping;
			}
			set
			{
				if (_enableSkipping == value)
				{
					return;
				}
				_enableSkipping = value;
				PropertySet(this);
			}
		}

		public questFinalBoardsEnableSkipCredits_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
