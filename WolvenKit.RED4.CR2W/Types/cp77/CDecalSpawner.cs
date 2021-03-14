using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CDecalSpawner : ISerializable
	{
		private rRef<IMaterial> _materialStatic;
		private rRef<IMaterial> _materialSkinned;
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
		public rRef<IMaterial> MaterialStatic
		{
			get
			{
				if (_materialStatic == null)
				{
					_materialStatic = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "materialStatic", cr2w, this);
				}
				return _materialStatic;
			}
			set
			{
				if (_materialStatic == value)
				{
					return;
				}
				_materialStatic = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("materialSkinned")] 
		public rRef<IMaterial> MaterialSkinned
		{
			get
			{
				if (_materialSkinned == null)
				{
					_materialSkinned = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "materialSkinned", cr2w, this);
				}
				return _materialSkinned;
			}
			set
			{
				if (_materialSkinned == value)
				{
					return;
				}
				_materialSkinned = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("specularColor")] 
		public CColor SpecularColor
		{
			get
			{
				if (_specularColor == null)
				{
					_specularColor = (CColor) CR2WTypeManager.Create("Color", "specularColor", cr2w, this);
				}
				return _specularColor;
			}
			set
			{
				if (_specularColor == value)
				{
					return;
				}
				_specularColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("specularScale")] 
		public CFloat SpecularScale
		{
			get
			{
				if (_specularScale == null)
				{
					_specularScale = (CFloat) CR2WTypeManager.Create("Float", "specularScale", cr2w, this);
				}
				return _specularScale;
			}
			set
			{
				if (_specularScale == value)
				{
					return;
				}
				_specularScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("specularBase")] 
		public CFloat SpecularBase
		{
			get
			{
				if (_specularBase == null)
				{
					_specularBase = (CFloat) CR2WTypeManager.Create("Float", "specularBase", cr2w, this);
				}
				return _specularBase;
			}
			set
			{
				if (_specularBase == value)
				{
					return;
				}
				_specularBase = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("roughnessScale")] 
		public CFloat RoughnessScale
		{
			get
			{
				if (_roughnessScale == null)
				{
					_roughnessScale = (CFloat) CR2WTypeManager.Create("Float", "roughnessScale", cr2w, this);
				}
				return _roughnessScale;
			}
			set
			{
				if (_roughnessScale == value)
				{
					return;
				}
				_roughnessScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("normalThreshold")] 
		public CFloat NormalThreshold
		{
			get
			{
				if (_normalThreshold == null)
				{
					_normalThreshold = (CFloat) CR2WTypeManager.Create("Float", "normalThreshold", cr2w, this);
				}
				return _normalThreshold;
			}
			set
			{
				if (_normalThreshold == value)
				{
					return;
				}
				_normalThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("additiveNormals")] 
		public CBool AdditiveNormals
		{
			get
			{
				if (_additiveNormals == null)
				{
					_additiveNormals = (CBool) CR2WTypeManager.Create("Bool", "additiveNormals", cr2w, this);
				}
				return _additiveNormals;
			}
			set
			{
				if (_additiveNormals == value)
				{
					return;
				}
				_additiveNormals = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("diffuseRandomColor0")] 
		public CColor DiffuseRandomColor0
		{
			get
			{
				if (_diffuseRandomColor0 == null)
				{
					_diffuseRandomColor0 = (CColor) CR2WTypeManager.Create("Color", "diffuseRandomColor0", cr2w, this);
				}
				return _diffuseRandomColor0;
			}
			set
			{
				if (_diffuseRandomColor0 == value)
				{
					return;
				}
				_diffuseRandomColor0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("diffuseRandomColor1")] 
		public CColor DiffuseRandomColor1
		{
			get
			{
				if (_diffuseRandomColor1 == null)
				{
					_diffuseRandomColor1 = (CColor) CR2WTypeManager.Create("Color", "diffuseRandomColor1", cr2w, this);
				}
				return _diffuseRandomColor1;
			}
			set
			{
				if (_diffuseRandomColor1 == value)
				{
					return;
				}
				_diffuseRandomColor1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("subUVType")] 
		public CEnum<ERenderDynamicDecalAtlas> SubUVType
		{
			get
			{
				if (_subUVType == null)
				{
					_subUVType = (CEnum<ERenderDynamicDecalAtlas>) CR2WTypeManager.Create("ERenderDynamicDecalAtlas", "subUVType", cr2w, this);
				}
				return _subUVType;
			}
			set
			{
				if (_subUVType == value)
				{
					return;
				}
				_subUVType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("specularity")] 
		public CFloat Specularity
		{
			get
			{
				if (_specularity == null)
				{
					_specularity = (CFloat) CR2WTypeManager.Create("Float", "specularity", cr2w, this);
				}
				return _specularity;
			}
			set
			{
				if (_specularity == value)
				{
					return;
				}
				_specularity = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("farZ")] 
		public CFloat FarZ
		{
			get
			{
				if (_farZ == null)
				{
					_farZ = (CFloat) CR2WTypeManager.Create("Float", "farZ", cr2w, this);
				}
				return _farZ;
			}
			set
			{
				if (_farZ == value)
				{
					return;
				}
				_farZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("nearZ")] 
		public CFloat NearZ
		{
			get
			{
				if (_nearZ == null)
				{
					_nearZ = (CFloat) CR2WTypeManager.Create("Float", "nearZ", cr2w, this);
				}
				return _nearZ;
			}
			set
			{
				if (_nearZ == value)
				{
					return;
				}
				_nearZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("size")] 
		public CHandle<IEvaluatorFloat> Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("depthFadePower")] 
		public CFloat DepthFadePower
		{
			get
			{
				if (_depthFadePower == null)
				{
					_depthFadePower = (CFloat) CR2WTypeManager.Create("Float", "depthFadePower", cr2w, this);
				}
				return _depthFadePower;
			}
			set
			{
				if (_depthFadePower == value)
				{
					return;
				}
				_depthFadePower = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("normalFadeBias")] 
		public CFloat NormalFadeBias
		{
			get
			{
				if (_normalFadeBias == null)
				{
					_normalFadeBias = (CFloat) CR2WTypeManager.Create("Float", "normalFadeBias", cr2w, this);
				}
				return _normalFadeBias;
			}
			set
			{
				if (_normalFadeBias == value)
				{
					return;
				}
				_normalFadeBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("normalFadeScale")] 
		public CFloat NormalFadeScale
		{
			get
			{
				if (_normalFadeScale == null)
				{
					_normalFadeScale = (CFloat) CR2WTypeManager.Create("Float", "normalFadeScale", cr2w, this);
				}
				return _normalFadeScale;
			}
			set
			{
				if (_normalFadeScale == value)
				{
					return;
				}
				_normalFadeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("doubleSided")] 
		public CBool DoubleSided
		{
			get
			{
				if (_doubleSided == null)
				{
					_doubleSided = (CBool) CR2WTypeManager.Create("Bool", "doubleSided", cr2w, this);
				}
				return _doubleSided;
			}
			set
			{
				if (_doubleSided == value)
				{
					return;
				}
				_doubleSided = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("projectionMode")] 
		public CEnum<ERenderDynamicDecalProjection> ProjectionMode
		{
			get
			{
				if (_projectionMode == null)
				{
					_projectionMode = (CEnum<ERenderDynamicDecalProjection>) CR2WTypeManager.Create("ERenderDynamicDecalProjection", "projectionMode", cr2w, this);
				}
				return _projectionMode;
			}
			set
			{
				if (_projectionMode == value)
				{
					return;
				}
				_projectionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("decalLifetime")] 
		public CHandle<IEvaluatorFloat> DecalLifetime
		{
			get
			{
				if (_decalLifetime == null)
				{
					_decalLifetime = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "decalLifetime", cr2w, this);
				}
				return _decalLifetime;
			}
			set
			{
				if (_decalLifetime == value)
				{
					return;
				}
				_decalLifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("decalFadeTime")] 
		public CFloat DecalFadeTime
		{
			get
			{
				if (_decalFadeTime == null)
				{
					_decalFadeTime = (CFloat) CR2WTypeManager.Create("Float", "decalFadeTime", cr2w, this);
				}
				return _decalFadeTime;
			}
			set
			{
				if (_decalFadeTime == value)
				{
					return;
				}
				_decalFadeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("decalFadeInTime")] 
		public CFloat DecalFadeInTime
		{
			get
			{
				if (_decalFadeInTime == null)
				{
					_decalFadeInTime = (CFloat) CR2WTypeManager.Create("Float", "decalFadeInTime", cr2w, this);
				}
				return _decalFadeInTime;
			}
			set
			{
				if (_decalFadeInTime == value)
				{
					return;
				}
				_decalFadeInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("projectOnStatic")] 
		public CBool ProjectOnStatic
		{
			get
			{
				if (_projectOnStatic == null)
				{
					_projectOnStatic = (CBool) CR2WTypeManager.Create("Bool", "projectOnStatic", cr2w, this);
				}
				return _projectOnStatic;
			}
			set
			{
				if (_projectOnStatic == value)
				{
					return;
				}
				_projectOnStatic = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("projectOnSkinned")] 
		public CBool ProjectOnSkinned
		{
			get
			{
				if (_projectOnSkinned == null)
				{
					_projectOnSkinned = (CBool) CR2WTypeManager.Create("Bool", "projectOnSkinned", cr2w, this);
				}
				return _projectOnSkinned;
			}
			set
			{
				if (_projectOnSkinned == value)
				{
					return;
				}
				_projectOnSkinned = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("startScale")] 
		public CFloat StartScale
		{
			get
			{
				if (_startScale == null)
				{
					_startScale = (CFloat) CR2WTypeManager.Create("Float", "startScale", cr2w, this);
				}
				return _startScale;
			}
			set
			{
				if (_startScale == value)
				{
					return;
				}
				_startScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("scaleTime")] 
		public CFloat ScaleTime
		{
			get
			{
				if (_scaleTime == null)
				{
					_scaleTime = (CFloat) CR2WTypeManager.Create("Float", "scaleTime", cr2w, this);
				}
				return _scaleTime;
			}
			set
			{
				if (_scaleTime == value)
				{
					return;
				}
				_scaleTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("useVerticalProjection")] 
		public CBool UseVerticalProjection
		{
			get
			{
				if (_useVerticalProjection == null)
				{
					_useVerticalProjection = (CBool) CR2WTypeManager.Create("Bool", "useVerticalProjection", cr2w, this);
				}
				return _useVerticalProjection;
			}
			set
			{
				if (_useVerticalProjection == value)
				{
					return;
				}
				_useVerticalProjection = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("spawnPriority")] 
		public CEnum<EDynamicDecalSpawnPriority> SpawnPriority
		{
			get
			{
				if (_spawnPriority == null)
				{
					_spawnPriority = (CEnum<EDynamicDecalSpawnPriority>) CR2WTypeManager.Create("EDynamicDecalSpawnPriority", "spawnPriority", cr2w, this);
				}
				return _spawnPriority;
			}
			set
			{
				if (_spawnPriority == value)
				{
					return;
				}
				_spawnPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get
			{
				if (_autoHideDistance == null)
				{
					_autoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "autoHideDistance", cr2w, this);
				}
				return _autoHideDistance;
			}
			set
			{
				if (_autoHideDistance == value)
				{
					return;
				}
				_autoHideDistance = value;
				PropertySet(this);
			}
		}

		public CDecalSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
