using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CDecalSpawner : ISerializable
	{
		private CResourceReference<IMaterial> _materialStatic;
		private CResourceReference<IMaterial> _materialSkinned;
		private CColor _specularColor;
		private CFloat _specularScale;
		private CFloat _specularBase;
		private CFloat _roughnessScale;
		private CFloat _normalThreshold;
		private CBool _additiveNormals;
		private CColor _diffuseRandomColor0;
		private CColor _diffuseRandomColor1;
		private CEnum<ERenderDynamicDecalAtlas> _subUVType;
		private CFloat _specularity;
		private CFloat _farZ;
		private CFloat _nearZ;
		private CHandle<IEvaluatorFloat> _size;
		private CFloat _depthFadePower;
		private CFloat _normalFadeBias;
		private CFloat _normalFadeScale;
		private CBool _doubleSided;
		private CEnum<ERenderDynamicDecalProjection> _projectionMode;
		private CHandle<IEvaluatorFloat> _decalLifetime;
		private CFloat _decalFadeTime;
		private CFloat _decalFadeInTime;
		private CBool _projectOnStatic;
		private CBool _projectOnSkinned;
		private CFloat _startScale;
		private CFloat _scaleTime;
		private CBool _useVerticalProjection;
		private CEnum<EDynamicDecalSpawnPriority> _spawnPriority;
		private CFloat _autoHideDistance;

		[Ordinal(0)] 
		[RED("materialStatic")] 
		public CResourceReference<IMaterial> MaterialStatic
		{
			get => GetProperty(ref _materialStatic);
			set => SetProperty(ref _materialStatic, value);
		}

		[Ordinal(1)] 
		[RED("materialSkinned")] 
		public CResourceReference<IMaterial> MaterialSkinned
		{
			get => GetProperty(ref _materialSkinned);
			set => SetProperty(ref _materialSkinned, value);
		}

		[Ordinal(2)] 
		[RED("specularColor")] 
		public CColor SpecularColor
		{
			get => GetProperty(ref _specularColor);
			set => SetProperty(ref _specularColor, value);
		}

		[Ordinal(3)] 
		[RED("specularScale")] 
		public CFloat SpecularScale
		{
			get => GetProperty(ref _specularScale);
			set => SetProperty(ref _specularScale, value);
		}

		[Ordinal(4)] 
		[RED("specularBase")] 
		public CFloat SpecularBase
		{
			get => GetProperty(ref _specularBase);
			set => SetProperty(ref _specularBase, value);
		}

		[Ordinal(5)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get => GetProperty(ref _roughnessScale);
			set => SetProperty(ref _roughnessScale, value);
		}

		[Ordinal(6)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get => GetProperty(ref _normalThreshold);
			set => SetProperty(ref _normalThreshold, value);
		}

		[Ordinal(7)] 
		[RED("additiveNormals")] 
		public CBool AdditiveNormals
		{
			get => GetProperty(ref _additiveNormals);
			set => SetProperty(ref _additiveNormals, value);
		}

		[Ordinal(8)] 
		[RED("diffuseRandomColor0")] 
		public CColor DiffuseRandomColor0
		{
			get => GetProperty(ref _diffuseRandomColor0);
			set => SetProperty(ref _diffuseRandomColor0, value);
		}

		[Ordinal(9)] 
		[RED("diffuseRandomColor1")] 
		public CColor DiffuseRandomColor1
		{
			get => GetProperty(ref _diffuseRandomColor1);
			set => SetProperty(ref _diffuseRandomColor1, value);
		}

		[Ordinal(10)] 
		[RED("subUVType")] 
		public CEnum<ERenderDynamicDecalAtlas> SubUVType
		{
			get => GetProperty(ref _subUVType);
			set => SetProperty(ref _subUVType, value);
		}

		[Ordinal(11)] 
		[RED("specularity")] 
		public CFloat Specularity
		{
			get => GetProperty(ref _specularity);
			set => SetProperty(ref _specularity, value);
		}

		[Ordinal(12)] 
		[RED("farZ")] 
		public CFloat FarZ
		{
			get => GetProperty(ref _farZ);
			set => SetProperty(ref _farZ, value);
		}

		[Ordinal(13)] 
		[RED("nearZ")] 
		public CFloat NearZ
		{
			get => GetProperty(ref _nearZ);
			set => SetProperty(ref _nearZ, value);
		}

		[Ordinal(14)] 
		[RED("size")] 
		public CHandle<IEvaluatorFloat> Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(15)] 
		[RED("depthFadePower")] 
		public CFloat DepthFadePower
		{
			get => GetProperty(ref _depthFadePower);
			set => SetProperty(ref _depthFadePower, value);
		}

		[Ordinal(16)] 
		[RED("normalFadeBias")] 
		public CFloat NormalFadeBias
		{
			get => GetProperty(ref _normalFadeBias);
			set => SetProperty(ref _normalFadeBias, value);
		}

		[Ordinal(17)] 
		[RED("normalFadeScale")] 
		public CFloat NormalFadeScale
		{
			get => GetProperty(ref _normalFadeScale);
			set => SetProperty(ref _normalFadeScale, value);
		}

		[Ordinal(18)] 
		[RED("doubleSided")] 
		public CBool DoubleSided
		{
			get => GetProperty(ref _doubleSided);
			set => SetProperty(ref _doubleSided, value);
		}

		[Ordinal(19)] 
		[RED("projectionMode")] 
		public CEnum<ERenderDynamicDecalProjection> ProjectionMode
		{
			get => GetProperty(ref _projectionMode);
			set => SetProperty(ref _projectionMode, value);
		}

		[Ordinal(20)] 
		[RED("decalLifetime")] 
		public CHandle<IEvaluatorFloat> DecalLifetime
		{
			get => GetProperty(ref _decalLifetime);
			set => SetProperty(ref _decalLifetime, value);
		}

		[Ordinal(21)] 
		[RED("decalFadeTime")] 
		public CFloat DecalFadeTime
		{
			get => GetProperty(ref _decalFadeTime);
			set => SetProperty(ref _decalFadeTime, value);
		}

		[Ordinal(22)] 
		[RED("decalFadeInTime")] 
		public CFloat DecalFadeInTime
		{
			get => GetProperty(ref _decalFadeInTime);
			set => SetProperty(ref _decalFadeInTime, value);
		}

		[Ordinal(23)] 
		[RED("projectOnStatic")] 
		public CBool ProjectOnStatic
		{
			get => GetProperty(ref _projectOnStatic);
			set => SetProperty(ref _projectOnStatic, value);
		}

		[Ordinal(24)] 
		[RED("projectOnSkinned")] 
		public CBool ProjectOnSkinned
		{
			get => GetProperty(ref _projectOnSkinned);
			set => SetProperty(ref _projectOnSkinned, value);
		}

		[Ordinal(25)] 
		[RED("startScale")] 
		public CFloat StartScale
		{
			get => GetProperty(ref _startScale);
			set => SetProperty(ref _startScale, value);
		}

		[Ordinal(26)] 
		[RED("scaleTime")] 
		public CFloat ScaleTime
		{
			get => GetProperty(ref _scaleTime);
			set => SetProperty(ref _scaleTime, value);
		}

		[Ordinal(27)] 
		[RED("useVerticalProjection")] 
		public CBool UseVerticalProjection
		{
			get => GetProperty(ref _useVerticalProjection);
			set => SetProperty(ref _useVerticalProjection, value);
		}

		[Ordinal(28)] 
		[RED("spawnPriority")] 
		public CEnum<EDynamicDecalSpawnPriority> SpawnPriority
		{
			get => GetProperty(ref _spawnPriority);
			set => SetProperty(ref _spawnPriority, value);
		}

		[Ordinal(29)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetProperty(ref _autoHideDistance);
			set => SetProperty(ref _autoHideDistance, value);
		}
	}
}
