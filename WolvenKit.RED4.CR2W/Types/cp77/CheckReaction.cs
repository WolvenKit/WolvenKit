using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReaction : AIbehaviorconditionScript
	{
		private CEnum<gamedataOutput> _reactionToCompare;

		[Ordinal(0)] 
		[RED("reactionToCompare")] 
		public CEnum<gamedataOutput> ReactionToCompare
		{
			get
			{
				if (_reactionToCompare == null)
				{
					_reactionToCompare = (CEnum<gamedataOutput>) CR2WTypeManager.Create("gamedataOutput", "reactionToCompare", cr2w, this);
				}
				return _reactionToCompare;
			}
			set
			{
				if (_reactionToCompare == value)
				{
					return;
				}
				_reactionToCompare = value;
				PropertySet(this);
			}
		}

		public CheckReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
