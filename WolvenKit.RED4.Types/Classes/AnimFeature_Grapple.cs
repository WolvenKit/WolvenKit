using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Grapple : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("inGrapple")] 
		public CBool InGrapple
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
