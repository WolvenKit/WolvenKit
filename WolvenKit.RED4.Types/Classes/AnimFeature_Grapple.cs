using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Grapple : animAnimFeature
	{
		private CBool _inGrapple;

		[Ordinal(0)] 
		[RED("inGrapple")] 
		public CBool InGrapple
		{
			get => GetProperty(ref _inGrapple);
			set => SetProperty(ref _inGrapple, value);
		}
	}
}
