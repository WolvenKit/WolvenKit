using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableWallScreen : Door
	{
		[Ordinal(140)] 
		[RED("animationLength")] 
		public CFloat AnimationLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(141)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		public MovableWallScreen()
		{
			ControllerTypeName = "MovableWallScreenController";
		}
	}
}
