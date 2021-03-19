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
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}

		public TargetNPCRarityHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
