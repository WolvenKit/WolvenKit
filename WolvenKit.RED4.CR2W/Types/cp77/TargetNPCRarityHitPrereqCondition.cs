using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetNPCRarityHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataNPCRarity> _rarity;

		[Ordinal(1)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get
			{
				if (_rarity == null)
				{
					_rarity = (CEnum<gamedataNPCRarity>) CR2WTypeManager.Create("gamedataNPCRarity", "rarity", cr2w, this);
				}
				return _rarity;
			}
			set
			{
				if (_rarity == value)
				{
					return;
				}
				_rarity = value;
				PropertySet(this);
			}
		}

		public TargetNPCRarityHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
