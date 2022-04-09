using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsMaterialResource : CResource
	{
		[Ordinal(1)] 
		[RED("staticFriction")] 
		public CFloat StaticFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("dynamicFriction")] 
		public CFloat DynamicFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("frictionMode")] 
		public CEnum<physicsMaterialFriction> FrictionMode
		{
			get => GetPropertyValue<CEnum<physicsMaterialFriction>>();
			set => SetPropertyValue<CEnum<physicsMaterialFriction>>(value);
		}

		[Ordinal(5)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public physicsMaterialTags Tags
		{
			get => GetPropertyValue<physicsMaterialTags>();
			set => SetPropertyValue<physicsMaterialTags>(value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(8)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public physicsMaterialResource()
		{
			StaticFriction = 0.500000F;
			DynamicFriction = 0.300000F;
			Restitution = 0.200000F;
			Density = 1000.000000F;
			Tags = new();
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
