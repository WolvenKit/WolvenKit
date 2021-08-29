using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SceneSystem : animAnimFeature
	{
		private CInt32 _tier;

		[Ordinal(0)] 
		[RED("tier")] 
		public CInt32 Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}
	}
}
