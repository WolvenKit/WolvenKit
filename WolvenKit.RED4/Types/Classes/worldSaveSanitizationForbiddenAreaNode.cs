using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSaveSanitizationForbiddenAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("safeSpotOffset")] 
		public Vector4 SafeSpotOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public worldSaveSanitizationForbiddenAreaNode()
		{
			Color = new CColor { Blue = 255, Alpha = 128 };
			SafeSpotOffset = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
