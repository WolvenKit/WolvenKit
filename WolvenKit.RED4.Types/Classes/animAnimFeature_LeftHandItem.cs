using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_LeftHandItem : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("itemInLeftHand")] 
		public CBool ItemInLeftHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
