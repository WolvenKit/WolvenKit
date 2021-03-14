using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticDecalNode : worldNode
	{
		private raRef<IMaterial> _material;
		private CFloat _autoHideDistance;
		private CBool _verticalFlip;
		private CBool _horizontalFlip;
		private CFloat _alpha;
		private CFloat _normalThreshold;
		private CFloat _roughnessScale;
		private HDRColor _diffuseColorScale;
		private CBool _isStretchingEnabled;
		private CBool _enableNormalTreshold;
		private CUInt16 _orderNo;
		private CEnum<ERenderObjectType> _surfaceType;
		private CEnum<RenderDecalNormalsBlendingMode> _normalsBlendingMode;
		private CEnum<EDecalRenderMode> _decalRenderMode;
		private CBool _shouldCollectWithRayTracing;
		private CFloat _forcedAutoHideDistance;
		private CUInt8 _decalNodeVersion;

		[Ordinal(4)] 
		[RED("material")] 
		public raRef<IMaterial> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (raRef<IMaterial>) CR2WTypeManager.Create("raRef:IMaterial", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("verticalFlip")] 
		public CBool VerticalFlip
		{
			get
			{
				if (_verticalFlip == null)
				{
					_verticalFlip = (CBool) CR2WTypeManager.Create("Bool", "verticalFlip", cr2w, this);
				}
				return _verticalFlip;
			}
			set
			{
				if (_verticalFlip == value)
				{
					return;
				}
				_verticalFlip = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("horizontalFlip")] 
		public CBool HorizontalFlip
		{
			get
			{
				if (_horizontalFlip == null)
				{
					_horizontalFlip = (CBool) CR2WTypeManager.Create("Bool", "horizontalFlip", cr2w, this);
				}
				return _horizontalFlip;
			}
			set
			{
				if (_horizontalFlip == value)
				{
					return;
				}
				_horizontalFlip = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CFloat) CR2WTypeManager.Create("Float", "alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("diffuseColorScale")] 
		public HDRColor DiffuseColorScale
		{
			get
			{
				if (_diffuseColorScale == null)
				{
					_diffuseColorScale = (HDRColor) CR2WTypeManager.Create("HDRColor", "diffuseColorScale", cr2w, this);
				}
				return _diffuseColorScale;
			}
			set
			{
				if (_diffuseColorScale == value)
				{
					return;
				}
				_diffuseColorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isStretchingEnabled")] 
		public CBool IsStretchingEnabled
		{
			get
			{
				if (_isStretchingEnabled == null)
				{
					_isStretchingEnabled = (CBool) CR2WTypeManager.Create("Bool", "isStretchingEnabled", cr2w, this);
				}
				return _isStretchingEnabled;
			}
			set
			{
				if (_isStretchingEnabled == value)
				{
					return;
				}
				_isStretchingEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("enableNormalTreshold")] 
		public CBool EnableNormalTreshold
		{
			get
			{
				if (_enableNormalTreshold == null)
				{
					_enableNormalTreshold = (CBool) CR2WTypeManager.Create("Bool", "enableNormalTreshold", cr2w, this);
				}
				return _enableNormalTreshold;
			}
			set
			{
				if (_enableNormalTreshold == value)
				{
					return;
				}
				_enableNormalTreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("orderNo")] 
		public CUInt16 OrderNo
		{
			get
			{
				if (_orderNo == null)
				{
					_orderNo = (CUInt16) CR2WTypeManager.Create("Uint16", "orderNo", cr2w, this);
				}
				return _orderNo;
			}
			set
			{
				if (_orderNo == value)
				{
					return;
				}
				_orderNo = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("surfaceType")] 
		public CEnum<ERenderObjectType> SurfaceType
		{
			get
			{
				if (_surfaceType == null)
				{
					_surfaceType = (CEnum<ERenderObjectType>) CR2WTypeManager.Create("ERenderObjectType", "surfaceType", cr2w, this);
				}
				return _surfaceType;
			}
			set
			{
				if (_surfaceType == value)
				{
					return;
				}
				_surfaceType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("normalsBlendingMode")] 
		public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
		{
			get
			{
				if (_normalsBlendingMode == null)
				{
					_normalsBlendingMode = (CEnum<RenderDecalNormalsBlendingMode>) CR2WTypeManager.Create("RenderDecalNormalsBlendingMode", "normalsBlendingMode", cr2w, this);
				}
				return _normalsBlendingMode;
			}
			set
			{
				if (_normalsBlendingMode == value)
				{
					return;
				}
				_normalsBlendingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("decalRenderMode")] 
		public CEnum<EDecalRenderMode> DecalRenderMode
		{
			get
			{
				if (_decalRenderMode == null)
				{
					_decalRenderMode = (CEnum<EDecalRenderMode>) CR2WTypeManager.Create("EDecalRenderMode", "decalRenderMode", cr2w, this);
				}
				return _decalRenderMode;
			}
			set
			{
				if (_decalRenderMode == value)
				{
					return;
				}
				_decalRenderMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("shouldCollectWithRayTracing")] 
		public CBool ShouldCollectWithRayTracing
		{
			get
			{
				if (_shouldCollectWithRayTracing == null)
				{
					_shouldCollectWithRayTracing = (CBool) CR2WTypeManager.Create("Bool", "shouldCollectWithRayTracing", cr2w, this);
				}
				return _shouldCollectWithRayTracing;
			}
			set
			{
				if (_shouldCollectWithRayTracing == value)
				{
					return;
				}
				_shouldCollectWithRayTracing = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("forcedAutoHideDistance")] 
		public CFloat ForcedAutoHideDistance
		{
			get
			{
				if (_forcedAutoHideDistance == null)
				{
					_forcedAutoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "forcedAutoHideDistance", cr2w, this);
				}
				return _forcedAutoHideDistance;
			}
			set
			{
				if (_forcedAutoHideDistance == value)
				{
					return;
				}
				_forcedAutoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("decalNodeVersion")] 
		public CUInt8 DecalNodeVersion
		{
			get
			{
				if (_decalNodeVersion == null)
				{
					_decalNodeVersion = (CUInt8) CR2WTypeManager.Create("Uint8", "decalNodeVersion", cr2w, this);
				}
				return _decalNodeVersion;
			}
			set
			{
				if (_decalNodeVersion == value)
				{
					return;
				}
				_decalNodeVersion = value;
				PropertySet(this);
			}
		}

		public worldStaticDecalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
