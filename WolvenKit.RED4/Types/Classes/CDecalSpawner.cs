using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CDecalSpawner : ISerializable
	{
		[Ordinal(0)] 
		[RED("materialStatic")] 
		public CResourceReference<IMaterial> MaterialStatic
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(1)] 
		[RED("materialSkinned")] 
		public CResourceReference<IMaterial> MaterialSkinned
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(2)] 
		[RED("specularColor")] 
		public CColor SpecularColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("specularScale")] 
		public CFloat SpecularScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("specularBase")] 
		public CFloat SpecularBase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("additiveNormals")] 
		public CBool AdditiveNormals
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("diffuseRandomColor0")] 
		public CColor DiffuseRandomColor0
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(9)] 
		[RED("diffuseRandomColor1")] 
		public CColor DiffuseRandomColor1
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(10)] 
		[RED("subUVType")] 
		public CEnum<ERenderDynamicDecalAtlas> SubUVType
		{
			get => GetPropertyValue<CEnum<ERenderDynamicDecalAtlas>>();
			set => SetPropertyValue<CEnum<ERenderDynamicDecalAtlas>>(value);
		}

		[Ordinal(11)] 
		[RED("specularity")] 
		public CFloat Specularity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("farZ")] 
		public CFloat FarZ
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("nearZ")] 
		public CFloat NearZ
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("size")] 
		public CHandle<IEvaluatorFloat> Size
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("depthFadePower")] 
		public CFloat DepthFadePower
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("normalFadeBias")] 
		public CFloat NormalFadeBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("normalFadeScale")] 
		public CFloat NormalFadeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("doubleSided")] 
		public CBool DoubleSided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("projectionMode")] 
		public CEnum<ERenderDynamicDecalProjection> ProjectionMode
		{
			get => GetPropertyValue<CEnum<ERenderDynamicDecalProjection>>();
			set => SetPropertyValue<CEnum<ERenderDynamicDecalProjection>>(value);
		}

		[Ordinal(20)] 
		[RED("decalLifetime")] 
		public CHandle<IEvaluatorFloat> DecalLifetime
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(21)] 
		[RED("decalFadeTime")] 
		public CFloat DecalFadeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("decalFadeInTime")] 
		public CFloat DecalFadeInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("projectOnStatic")] 
		public CBool ProjectOnStatic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("projectOnSkinned")] 
		public CBool ProjectOnSkinned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("startScale")] 
		public CFloat StartScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("scaleTime")] 
		public CFloat ScaleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("useVerticalProjection")] 
		public CBool UseVerticalProjection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("spawnPriority")] 
		public CEnum<EDynamicDecalSpawnPriority> SpawnPriority
		{
			get => GetPropertyValue<CEnum<EDynamicDecalSpawnPriority>>();
			set => SetPropertyValue<CEnum<EDynamicDecalSpawnPriority>>(value);
		}

		[Ordinal(29)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CDecalSpawner()
		{
			SpecularColor = new CColor();
			SpecularBase = 1.000000F;
			RoughnessScale = 1.000000F;
			NormalThreshold = 1.000000F;
			AdditiveNormals = true;
			DiffuseRandomColor0 = new CColor();
			DiffuseRandomColor1 = new CColor();
			Specularity = -1.000000F;
			FarZ = 1.000000F;
			NormalFadeScale = 1.000000F;
			DecalFadeTime = 0.100000F;
			DecalFadeInTime = 0.100000F;
			ProjectOnStatic = true;
			ProjectOnSkinned = true;
			StartScale = 1.000000F;
			ScaleTime = 1.000000F;
			AutoHideDistance = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
