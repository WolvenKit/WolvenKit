using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDecalComponent : entIVisualComponent
	{
		private rRef<IMaterial> _material;
		private CBool _verticalFlip;
		private CBool _horizontalFlip;
		private CFloat _aspectRatio;
		private CFloat _scale;
		private Vector3 _visualScale;
		private CFloat _alpha;
		private CFloat _normalThreshold;
		private CFloat _roughnessScale;
		private CUInt16 _orderNo;
		private CEnum<ERenderObjectType> _surfaceType;
		private CEnum<EDecalRenderMode> _decalRenderMode;
		private CBool _isStretchingEnabled;
		private CEnum<RenderDecalNormalsBlendingMode> _normalsBlendingMode;
		private CBool _shouldCollectWithRayTracing;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("material")] 
		public rRef<IMaterial> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "material", cr2w, this);
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("aspectRatio")] 
		public CFloat AspectRatio
		{
			get
			{
				if (_aspectRatio == null)
				{
					_aspectRatio = (CFloat) CR2WTypeManager.Create("Float", "aspectRatio", cr2w, this);
				}
				return _aspectRatio;
			}
			set
			{
				if (_aspectRatio == value)
				{
					return;
				}
				_aspectRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get
			{
				if (_visualScale == null)
				{
					_visualScale = (Vector3) CR2WTypeManager.Create("Vector3", "visualScale", cr2w, this);
				}
				return _visualScale;
			}
			set
			{
				if (_visualScale == value)
				{
					return;
				}
				_visualScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public entDecalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
