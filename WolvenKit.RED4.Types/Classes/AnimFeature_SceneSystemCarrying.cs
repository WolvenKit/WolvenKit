using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SceneSystemCarrying : animAnimFeature
	{
		private CBool _carrying;

		[Ordinal(0)] 
		[RED("carrying")] 
		public CBool Carrying
		{
			get => GetProperty(ref _carrying);
			set => SetProperty(ref _carrying, value);
		}
	}
}
