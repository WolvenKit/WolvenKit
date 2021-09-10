using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PlayerPeekScale : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("peekScale")] 
		public CFloat PeekScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
