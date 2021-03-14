using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReactionValueThreshold : AIbehaviorconditionScript
	{
		private CEnum<EReactionValue> _reactionValue;

		[Ordinal(0)] 
		[RED("reactionValue")] 
		public CEnum<EReactionValue> ReactionValue
		{
			get
			{
				if (_reactionValue == null)
				{
					_reactionValue = (CEnum<EReactionValue>) CR2WTypeManager.Create("EReactionValue", "reactionValue", cr2w, this);
				}
				return _reactionValue;
			}
			set
			{
				if (_reactionValue == value)
				{
					return;
				}
				_reactionValue = value;
				PropertySet(this);
			}
		}

		public CheckReactionValueThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
