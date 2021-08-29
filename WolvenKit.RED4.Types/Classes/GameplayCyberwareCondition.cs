using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayCyberwareCondition : GameplayConditionBase
	{
		private TweakDBID _cyberwareToCheck;

		[Ordinal(1)] 
		[RED("cyberwareToCheck")] 
		public TweakDBID CyberwareToCheck
		{
			get => GetProperty(ref _cyberwareToCheck);
			set => SetProperty(ref _cyberwareToCheck, value);
		}
	}
}
