using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentHitReaction : HitConditions
	{
		private CEnum<animHitReactionType> _hitReactionTypeToCompare;
		private CName _customStimNameToCompare;
		private CBool _shouldCheckDeathStimName;

		[Ordinal(0)] 
		[RED("HitReactionTypeToCompare")] 
		public CEnum<animHitReactionType> HitReactionTypeToCompare
		{
			get
			{
				if (_hitReactionTypeToCompare == null)
				{
					_hitReactionTypeToCompare = (CEnum<animHitReactionType>) CR2WTypeManager.Create("animHitReactionType", "HitReactionTypeToCompare", cr2w, this);
				}
				return _hitReactionTypeToCompare;
			}
			set
			{
				if (_hitReactionTypeToCompare == value)
				{
					return;
				}
				_hitReactionTypeToCompare = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CustomStimNameToCompare")] 
		public CName CustomStimNameToCompare
		{
			get
			{
				if (_customStimNameToCompare == null)
				{
					_customStimNameToCompare = (CName) CR2WTypeManager.Create("CName", "CustomStimNameToCompare", cr2w, this);
				}
				return _customStimNameToCompare;
			}
			set
			{
				if (_customStimNameToCompare == value)
				{
					return;
				}
				_customStimNameToCompare = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shouldCheckDeathStimName")] 
		public CBool ShouldCheckDeathStimName
		{
			get
			{
				if (_shouldCheckDeathStimName == null)
				{
					_shouldCheckDeathStimName = (CBool) CR2WTypeManager.Create("Bool", "shouldCheckDeathStimName", cr2w, this);
				}
				return _shouldCheckDeathStimName;
			}
			set
			{
				if (_shouldCheckDeathStimName == value)
				{
					return;
				}
				_shouldCheckDeathStimName = value;
				PropertySet(this);
			}
		}

		public CheckCurrentHitReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
