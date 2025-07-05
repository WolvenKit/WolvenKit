using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_SceneSystemCarrying : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("carrying")] 
		public CBool Carrying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimFeature_SceneSystemCarrying()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
