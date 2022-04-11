using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTerrainEditToolCreationSlotInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("scale")] 
		public Vector2 Scale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("heightMappingOverrideEnable")] 
		public CBool HeightMappingOverrideEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("heightMappingMin")] 
		public CFloat HeightMappingMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("heightMappingMax")] 
		public CFloat HeightMappingMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public interopTerrainEditToolCreationSlotInfo()
		{
			Scale = new() { X = 1.000000F, Y = 1.000000F };
			HeightMappingMax = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
