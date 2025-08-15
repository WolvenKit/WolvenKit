using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PhotomodeBodyPartRotate : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("rotateDegree")] 
		public CFloat RotateDegree
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_PhotomodeBodyPartRotate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
