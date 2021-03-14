using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyMiscAdvancedParams : CVariable
	{
		private CBool _useLod1;
		private CBool _smoothVolume;
		private CUInt8 _blurCutout;
		private CUInt8 _occlusionRatio;
		private CBool _capTop;
		private CBool _capBottom;
		private CFloat _fillHolesBeforeReduceRatio;
		private CFloat _fillHolesAfterReduceRatio;
		private CInt32 _rsSweepOrder;
		private CFloat _rsDetailDrop;
		private Vector3 _rsAxisPrecision;
		private Vector3 _rsAxisExpand;
		private CFloat _rsAliasingReduction;
		private CFloat _bcMergeRange;
		private CFloat _bcSizeCutoff;
		private CFloat _bcIterations;
		private CFloat _bcMaxSize;
		private CFloat _bcMinSize;
		private CFloat _bcMergeSensitivity;
		private CFloat _bcMinScale;
		private CFloat _bcGridSize;
		private CFloat _bcFilterSensitivity;
		private CFloat _bcBoundsRatioLimit;
		private CBool _useClosestPointOnMesh;
		private CBool _removeIslands;
		private CColor _backgroundColor;

		[Ordinal(0)] 
		[RED("useLod1")] 
		public CBool UseLod1
		{
			get
			{
				if (_useLod1 == null)
				{
					_useLod1 = (CBool) CR2WTypeManager.Create("Bool", "useLod1", cr2w, this);
				}
				return _useLod1;
			}
			set
			{
				if (_useLod1 == value)
				{
					return;
				}
				_useLod1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("smoothVolume")] 
		public CBool SmoothVolume
		{
			get
			{
				if (_smoothVolume == null)
				{
					_smoothVolume = (CBool) CR2WTypeManager.Create("Bool", "smoothVolume", cr2w, this);
				}
				return _smoothVolume;
			}
			set
			{
				if (_smoothVolume == value)
				{
					return;
				}
				_smoothVolume = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blurCutout")] 
		public CUInt8 BlurCutout
		{
			get
			{
				if (_blurCutout == null)
				{
					_blurCutout = (CUInt8) CR2WTypeManager.Create("Uint8", "blurCutout", cr2w, this);
				}
				return _blurCutout;
			}
			set
			{
				if (_blurCutout == value)
				{
					return;
				}
				_blurCutout = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("occlusionRatio")] 
		public CUInt8 OcclusionRatio
		{
			get
			{
				if (_occlusionRatio == null)
				{
					_occlusionRatio = (CUInt8) CR2WTypeManager.Create("Uint8", "occlusionRatio", cr2w, this);
				}
				return _occlusionRatio;
			}
			set
			{
				if (_occlusionRatio == value)
				{
					return;
				}
				_occlusionRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("capTop")] 
		public CBool CapTop
		{
			get
			{
				if (_capTop == null)
				{
					_capTop = (CBool) CR2WTypeManager.Create("Bool", "capTop", cr2w, this);
				}
				return _capTop;
			}
			set
			{
				if (_capTop == value)
				{
					return;
				}
				_capTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("capBottom")] 
		public CBool CapBottom
		{
			get
			{
				if (_capBottom == null)
				{
					_capBottom = (CBool) CR2WTypeManager.Create("Bool", "capBottom", cr2w, this);
				}
				return _capBottom;
			}
			set
			{
				if (_capBottom == value)
				{
					return;
				}
				_capBottom = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fillHolesBeforeReduceRatio")] 
		public CFloat FillHolesBeforeReduceRatio
		{
			get
			{
				if (_fillHolesBeforeReduceRatio == null)
				{
					_fillHolesBeforeReduceRatio = (CFloat) CR2WTypeManager.Create("Float", "fillHolesBeforeReduceRatio", cr2w, this);
				}
				return _fillHolesBeforeReduceRatio;
			}
			set
			{
				if (_fillHolesBeforeReduceRatio == value)
				{
					return;
				}
				_fillHolesBeforeReduceRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fillHolesAfterReduceRatio")] 
		public CFloat FillHolesAfterReduceRatio
		{
			get
			{
				if (_fillHolesAfterReduceRatio == null)
				{
					_fillHolesAfterReduceRatio = (CFloat) CR2WTypeManager.Create("Float", "fillHolesAfterReduceRatio", cr2w, this);
				}
				return _fillHolesAfterReduceRatio;
			}
			set
			{
				if (_fillHolesAfterReduceRatio == value)
				{
					return;
				}
				_fillHolesAfterReduceRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rsSweepOrder")] 
		public CInt32 RsSweepOrder
		{
			get
			{
				if (_rsSweepOrder == null)
				{
					_rsSweepOrder = (CInt32) CR2WTypeManager.Create("Int32", "rsSweepOrder", cr2w, this);
				}
				return _rsSweepOrder;
			}
			set
			{
				if (_rsSweepOrder == value)
				{
					return;
				}
				_rsSweepOrder = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rsDetailDrop")] 
		public CFloat RsDetailDrop
		{
			get
			{
				if (_rsDetailDrop == null)
				{
					_rsDetailDrop = (CFloat) CR2WTypeManager.Create("Float", "rsDetailDrop", cr2w, this);
				}
				return _rsDetailDrop;
			}
			set
			{
				if (_rsDetailDrop == value)
				{
					return;
				}
				_rsDetailDrop = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rsAxisPrecision")] 
		public Vector3 RsAxisPrecision
		{
			get
			{
				if (_rsAxisPrecision == null)
				{
					_rsAxisPrecision = (Vector3) CR2WTypeManager.Create("Vector3", "rsAxisPrecision", cr2w, this);
				}
				return _rsAxisPrecision;
			}
			set
			{
				if (_rsAxisPrecision == value)
				{
					return;
				}
				_rsAxisPrecision = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rsAxisExpand")] 
		public Vector3 RsAxisExpand
		{
			get
			{
				if (_rsAxisExpand == null)
				{
					_rsAxisExpand = (Vector3) CR2WTypeManager.Create("Vector3", "rsAxisExpand", cr2w, this);
				}
				return _rsAxisExpand;
			}
			set
			{
				if (_rsAxisExpand == value)
				{
					return;
				}
				_rsAxisExpand = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rsAliasingReduction")] 
		public CFloat RsAliasingReduction
		{
			get
			{
				if (_rsAliasingReduction == null)
				{
					_rsAliasingReduction = (CFloat) CR2WTypeManager.Create("Float", "rsAliasingReduction", cr2w, this);
				}
				return _rsAliasingReduction;
			}
			set
			{
				if (_rsAliasingReduction == value)
				{
					return;
				}
				_rsAliasingReduction = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bcMergeRange")] 
		public CFloat BcMergeRange
		{
			get
			{
				if (_bcMergeRange == null)
				{
					_bcMergeRange = (CFloat) CR2WTypeManager.Create("Float", "bcMergeRange", cr2w, this);
				}
				return _bcMergeRange;
			}
			set
			{
				if (_bcMergeRange == value)
				{
					return;
				}
				_bcMergeRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bcSizeCutoff")] 
		public CFloat BcSizeCutoff
		{
			get
			{
				if (_bcSizeCutoff == null)
				{
					_bcSizeCutoff = (CFloat) CR2WTypeManager.Create("Float", "bcSizeCutoff", cr2w, this);
				}
				return _bcSizeCutoff;
			}
			set
			{
				if (_bcSizeCutoff == value)
				{
					return;
				}
				_bcSizeCutoff = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bcIterations")] 
		public CFloat BcIterations
		{
			get
			{
				if (_bcIterations == null)
				{
					_bcIterations = (CFloat) CR2WTypeManager.Create("Float", "bcIterations", cr2w, this);
				}
				return _bcIterations;
			}
			set
			{
				if (_bcIterations == value)
				{
					return;
				}
				_bcIterations = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bcMaxSize")] 
		public CFloat BcMaxSize
		{
			get
			{
				if (_bcMaxSize == null)
				{
					_bcMaxSize = (CFloat) CR2WTypeManager.Create("Float", "bcMaxSize", cr2w, this);
				}
				return _bcMaxSize;
			}
			set
			{
				if (_bcMaxSize == value)
				{
					return;
				}
				_bcMaxSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bcMinSize")] 
		public CFloat BcMinSize
		{
			get
			{
				if (_bcMinSize == null)
				{
					_bcMinSize = (CFloat) CR2WTypeManager.Create("Float", "bcMinSize", cr2w, this);
				}
				return _bcMinSize;
			}
			set
			{
				if (_bcMinSize == value)
				{
					return;
				}
				_bcMinSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bcMergeSensitivity")] 
		public CFloat BcMergeSensitivity
		{
			get
			{
				if (_bcMergeSensitivity == null)
				{
					_bcMergeSensitivity = (CFloat) CR2WTypeManager.Create("Float", "bcMergeSensitivity", cr2w, this);
				}
				return _bcMergeSensitivity;
			}
			set
			{
				if (_bcMergeSensitivity == value)
				{
					return;
				}
				_bcMergeSensitivity = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("bcMinScale")] 
		public CFloat BcMinScale
		{
			get
			{
				if (_bcMinScale == null)
				{
					_bcMinScale = (CFloat) CR2WTypeManager.Create("Float", "bcMinScale", cr2w, this);
				}
				return _bcMinScale;
			}
			set
			{
				if (_bcMinScale == value)
				{
					return;
				}
				_bcMinScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("bcGridSize")] 
		public CFloat BcGridSize
		{
			get
			{
				if (_bcGridSize == null)
				{
					_bcGridSize = (CFloat) CR2WTypeManager.Create("Float", "bcGridSize", cr2w, this);
				}
				return _bcGridSize;
			}
			set
			{
				if (_bcGridSize == value)
				{
					return;
				}
				_bcGridSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("bcFilterSensitivity")] 
		public CFloat BcFilterSensitivity
		{
			get
			{
				if (_bcFilterSensitivity == null)
				{
					_bcFilterSensitivity = (CFloat) CR2WTypeManager.Create("Float", "bcFilterSensitivity", cr2w, this);
				}
				return _bcFilterSensitivity;
			}
			set
			{
				if (_bcFilterSensitivity == value)
				{
					return;
				}
				_bcFilterSensitivity = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("bcBoundsRatioLimit")] 
		public CFloat BcBoundsRatioLimit
		{
			get
			{
				if (_bcBoundsRatioLimit == null)
				{
					_bcBoundsRatioLimit = (CFloat) CR2WTypeManager.Create("Float", "bcBoundsRatioLimit", cr2w, this);
				}
				return _bcBoundsRatioLimit;
			}
			set
			{
				if (_bcBoundsRatioLimit == value)
				{
					return;
				}
				_bcBoundsRatioLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("useClosestPointOnMesh")] 
		public CBool UseClosestPointOnMesh
		{
			get
			{
				if (_useClosestPointOnMesh == null)
				{
					_useClosestPointOnMesh = (CBool) CR2WTypeManager.Create("Bool", "useClosestPointOnMesh", cr2w, this);
				}
				return _useClosestPointOnMesh;
			}
			set
			{
				if (_useClosestPointOnMesh == value)
				{
					return;
				}
				_useClosestPointOnMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("removeIslands")] 
		public CBool RemoveIslands
		{
			get
			{
				if (_removeIslands == null)
				{
					_removeIslands = (CBool) CR2WTypeManager.Create("Bool", "removeIslands", cr2w, this);
				}
				return _removeIslands;
			}
			set
			{
				if (_removeIslands == value)
				{
					return;
				}
				_removeIslands = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get
			{
				if (_backgroundColor == null)
				{
					_backgroundColor = (CColor) CR2WTypeManager.Create("Color", "backgroundColor", cr2w, this);
				}
				return _backgroundColor;
			}
			set
			{
				if (_backgroundColor == value)
				{
					return;
				}
				_backgroundColor = value;
				PropertySet(this);
			}
		}

		public worldProxyMiscAdvancedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
