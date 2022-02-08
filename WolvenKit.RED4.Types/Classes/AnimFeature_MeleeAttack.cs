using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_MeleeAttack : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
