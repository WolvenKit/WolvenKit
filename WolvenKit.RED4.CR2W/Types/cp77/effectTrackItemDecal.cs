using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDecal : effectTrackItem
	{
		private rRef<IMaterial> _material;
		private CHandle<IEvaluatorVector> _scale;
		private CHandle<IEvaluatorVector> _emissiveScale;
		private CFloat _normalThreshold;
		private CBool _horizontalFlip;
		private CBool _verticalFlip;
		private CFloat _fadeOutTime;
		private CFloat _fadeInTime;
		private CFloat _additionalRotation;
		private CBool _randomRotation;
		private CBool _randomAtlasing;
		private CBool _isStretchEnabled;
		private CBool _isAttached;
		private CEnum<RenderDecalNormalsBlendingMode> _normalsBlendingMode;
		private CInt32 _atlasFrameStart;
		private CInt32 _atlasFrameEnd;
		private CEnum<RenderDecalOrderPriority> _orderPriority;
		private CEnum<ERenderObjectType> _surfaceType;
		private CEnum<EDecalRenderMode> _decalRenderMode;

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "scale", cr2w, this);
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

		[Ordinal(5)] 
		[RED("emissiveScale")] 
		public CHandle<IEvaluatorVector> EmissiveScale
		{
			get
			{
				if (_emissiveScale == null)
				{
					_emissiveScale = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "emissiveScale", cr2w, this);
				}
				return _emissiveScale;
			}
			set
			{
				if (_emissiveScale == value)
				{
					return;
				}
				_emissiveScale = value;
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

		[Ordinal(9)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get
			{
				if (_fadeOutTime == null)
				{
					_fadeOutTime = (CFloat) CR2WTypeManager.Create("Float", "fadeOutTime", cr2w, this);
				}
				return _fadeOutTime;
			}
			set
			{
				if (_fadeOutTime == value)
				{
					return;
				}
				_fadeOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get
			{
				if (_fadeInTime == null)
				{
					_fadeInTime = (CFloat) CR2WTypeManager.Create("Float", "fadeInTime", cr2w, this);
				}
				return _fadeInTime;
			}
			set
			{
				if (_fadeInTime == value)
				{
					return;
				}
				_fadeInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get
			{
				if (_additionalRotation == null)
				{
					_additionalRotation = (CFloat) CR2WTypeManager.Create("Float", "additionalRotation", cr2w, this);
				}
				return _additionalRotation;
			}
			set
			{
				if (_additionalRotation == value)
				{
					return;
				}
				_additionalRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get
			{
				if (_randomRotation == null)
				{
					_randomRotation = (CBool) CR2WTypeManager.Create("Bool", "randomRotation", cr2w, this);
				}
				return _randomRotation;
			}
			set
			{
				if (_randomRotation == value)
				{
					return;
				}
				_randomRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("randomAtlasing")] 
		public CBool RandomAtlasing
		{
			get
			{
				if (_randomAtlasing == null)
				{
					_randomAtlasing = (CBool) CR2WTypeManager.Create("Bool", "randomAtlasing", cr2w, this);
				}
				return _randomAtlasing;
			}
			set
			{
				if (_randomAtlasing == value)
				{
					return;
				}
				_randomAtlasing = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isStretchEnabled")] 
		public CBool IsStretchEnabled
		{
			get
			{
				if (_isStretchEnabled == null)
				{
					_isStretchEnabled = (CBool) CR2WTypeManager.Create("Bool", "isStretchEnabled", cr2w, this);
				}
				return _isStretchEnabled;
			}
			set
			{
				if (_isStretchEnabled == value)
				{
					return;
				}
				_isStretchEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get
			{
				if (_isAttached == null)
				{
					_isAttached = (CBool) CR2WTypeManager.Create("Bool", "isAttached", cr2w, this);
				}
				return _isAttached;
			}
			set
			{
				if (_isAttached == value)
				{
					return;
				}
				_isAttached = value;
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
		[RED("atlasFrameStart")] 
		public CInt32 AtlasFrameStart
		{
			get
			{
				if (_atlasFrameStart == null)
				{
					_atlasFrameStart = (CInt32) CR2WTypeManager.Create("Int32", "atlasFrameStart", cr2w, this);
				}
				return _atlasFrameStart;
			}
			set
			{
				if (_atlasFrameStart == value)
				{
					return;
				}
				_atlasFrameStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("atlasFrameEnd")] 
		public CInt32 AtlasFrameEnd
		{
			get
			{
				if (_atlasFrameEnd == null)
				{
					_atlasFrameEnd = (CInt32) CR2WTypeManager.Create("Int32", "atlasFrameEnd", cr2w, this);
				}
				return _atlasFrameEnd;
			}
			set
			{
				if (_atlasFrameEnd == value)
				{
					return;
				}
				_atlasFrameEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("orderPriority")] 
		public CEnum<RenderDecalOrderPriority> OrderPriority
		{
			get
			{
				if (_orderPriority == null)
				{
					_orderPriority = (CEnum<RenderDecalOrderPriority>) CR2WTypeManager.Create("RenderDecalOrderPriority", "orderPriority", cr2w, this);
				}
				return _orderPriority;
			}
			set
			{
				if (_orderPriority == value)
				{
					return;
				}
				_orderPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		public effectTrackItemDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
