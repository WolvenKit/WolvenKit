using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CombatState : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
