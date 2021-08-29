using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CombatState : animAnimFeature
	{
		private CBool _isInCombat;

		[Ordinal(0)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetProperty(ref _isInCombat);
			set => SetProperty(ref _isInCombat, value);
		}
	}
}
