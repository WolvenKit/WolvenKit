using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendTextureRegionPart : ISerializable
	{
		[Ordinal(0)] 
		[RED("innerRegion")] 
		public Vector4 InnerRegion
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("outerRegion")] 
		public Vector4 OuterRegion
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public rendTextureRegionPart()
		{
			InnerRegion = new();
			OuterRegion = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
