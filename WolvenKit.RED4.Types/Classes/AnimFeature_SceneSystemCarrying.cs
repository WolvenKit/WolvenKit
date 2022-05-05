using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SceneSystemCarrying : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("carrying")] 
		public CBool Carrying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_SceneSystemCarrying()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
