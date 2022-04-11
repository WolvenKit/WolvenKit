using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentWoundDecal : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("OffsetA")] 
		public Vector3 OffsetA
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("OffsetB")] 
		public Vector3 OffsetB
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("FadeOrigin")] 
		public CFloat FadeOrigin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("FadePower")] 
		public CFloat FadePower
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("ResourceSets")] 
		public CBitField<entdismembermentResourceSetMask> ResourceSets
		{
			get => GetPropertyValue<CBitField<entdismembermentResourceSetMask>>();
			set => SetPropertyValue<CBitField<entdismembermentResourceSetMask>>(value);
		}

		[Ordinal(6)] 
		[RED("Material")] 
		public CResourceAsyncReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceAsyncReference<IMaterial>>();
			set => SetPropertyValue<CResourceAsyncReference<IMaterial>>(value);
		}

		public entdismembermentWoundDecal()
		{
			OffsetA = new();
			OffsetB = new();
			Scale = 1.000000F;
			FadeOrigin = 0.700000F;
			FadePower = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
