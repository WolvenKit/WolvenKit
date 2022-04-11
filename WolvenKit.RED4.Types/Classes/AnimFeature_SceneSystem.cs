using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SceneSystem : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("tier")] 
		public CInt32 Tier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_SceneSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
