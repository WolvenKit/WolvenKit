using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneTier_ConditionType : questISceneConditionType
	{
		private CEnum<GameplayTier> _tier;
		private CBool _isInverted;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(1)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetProperty(ref _isInverted);
			set => SetProperty(ref _isInverted, value);
		}

		public questSceneTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
