using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConditionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		private CBool _isInverted;

		[Ordinal(0)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get
			{
				if (_isInverted == null)
				{
					_isInverted = (CBool) CR2WTypeManager.Create("Bool", "isInverted", cr2w, this);
				}
				return _isInverted;
			}
			set
			{
				if (_isInverted == value)
				{
					return;
				}
				_isInverted = value;
				PropertySet(this);
			}
		}

		public AIbehaviorConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
