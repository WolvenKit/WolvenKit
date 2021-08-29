using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PlayerPeekScale : animAnimFeature
	{
		private CFloat _peekScale;

		[Ordinal(0)] 
		[RED("peekScale")] 
		public CFloat PeekScale
		{
			get => GetProperty(ref _peekScale);
			set => SetProperty(ref _peekScale, value);
		}
	}
}
