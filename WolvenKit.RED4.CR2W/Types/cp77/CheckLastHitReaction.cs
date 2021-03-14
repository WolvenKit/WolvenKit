using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckLastHitReaction : HitConditions
	{
		private CEnum<animHitReactionType> _hitReactionToCheck;

		[Ordinal(0)] 
		[RED("hitReactionToCheck")] 
		public CEnum<animHitReactionType> HitReactionToCheck
		{
			get
			{
				if (_hitReactionToCheck == null)
				{
					_hitReactionToCheck = (CEnum<animHitReactionType>) CR2WTypeManager.Create("animHitReactionType", "hitReactionToCheck", cr2w, this);
				}
				return _hitReactionToCheck;
			}
			set
			{
				if (_hitReactionToCheck == value)
				{
					return;
				}
				_hitReactionToCheck = value;
				PropertySet(this);
			}
		}

		public CheckLastHitReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
