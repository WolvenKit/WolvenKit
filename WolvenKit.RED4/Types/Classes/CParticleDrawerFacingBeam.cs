using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerFacingBeam : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("texturesPerUnit")] 
		public CFloat TexturesPerUnit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("dynamicTexCoords")] 
		public CBool DynamicTexCoords
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("transparencyOffset")] 
		public CFloat TransparencyOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("transparencyLength")] 
		public CFloat TransparencyLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("numSegments")] 
		public CUInt32 NumSegments
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("sourceTangent")] 
		public Vector4 SourceTangent
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("targetTangent")] 
		public Vector4 TargetTangent
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("debugTargetTranslation")] 
		public Vector3 DebugTargetTranslation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public CParticleDrawerFacingBeam()
		{
			TexturesPerUnit = 1.000000F;
			NumSegments = 10;
			SourceTangent = new Vector4();
			TargetTangent = new Vector4();
			DebugTargetTranslation = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
