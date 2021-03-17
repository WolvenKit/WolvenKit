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
			get => GetProperty(ref _useLod1);
			set => SetProperty(ref _useLod1, value);
		}

		[Ordinal(1)] 
		[RED("smoothVolume")] 
		public CBool SmoothVolume
		{
			get => GetProperty(ref _smoothVolume);
			set => SetProperty(ref _smoothVolume, value);
		}

		[Ordinal(2)] 
		[RED("blurCutout")] 
		public CUInt8 BlurCutout
		{
			get => GetProperty(ref _blurCutout);
			set => SetProperty(ref _blurCutout, value);
		}

		[Ordinal(3)] 
		[RED("occlusionRatio")] 
		public CUInt8 OcclusionRatio
		{
			get => GetProperty(ref _occlusionRatio);
			set => SetProperty(ref _occlusionRatio, value);
		}

		[Ordinal(4)] 
		[RED("capTop")] 
		public CBool CapTop
		{
			get => GetProperty(ref _capTop);
			set => SetProperty(ref _capTop, value);
		}

		[Ordinal(5)] 
		[RED("capBottom")] 
		public CBool CapBottom
		{
			get => GetProperty(ref _capBottom);
			set => SetProperty(ref _capBottom, value);
		}

		[Ordinal(6)] 
		[RED("fillHolesBeforeReduceRatio")] 
		public CFloat FillHolesBeforeReduceRatio
		{
			get => GetProperty(ref _fillHolesBeforeReduceRatio);
			set => SetProperty(ref _fillHolesBeforeReduceRatio, value);
		}

		[Ordinal(7)] 
		[RED("fillHolesAfterReduceRatio")] 
		public CFloat FillHolesAfterReduceRatio
		{
			get => GetProperty(ref _fillHolesAfterReduceRatio);
			set => SetProperty(ref _fillHolesAfterReduceRatio, value);
		}

		[Ordinal(8)] 
		[RED("rsSweepOrder")] 
		public CInt32 RsSweepOrder
		{
			get => GetProperty(ref _rsSweepOrder);
			set => SetProperty(ref _rsSweepOrder, value);
		}

		[Ordinal(9)] 
		[RED("rsDetailDrop")] 
		public CFloat RsDetailDrop
		{
			get => GetProperty(ref _rsDetailDrop);
			set => SetProperty(ref _rsDetailDrop, value);
		}

		[Ordinal(10)] 
		[RED("rsAxisPrecision")] 
		public Vector3 RsAxisPrecision
		{
			get => GetProperty(ref _rsAxisPrecision);
			set => SetProperty(ref _rsAxisPrecision, value);
		}

		[Ordinal(11)] 
		[RED("rsAxisExpand")] 
		public Vector3 RsAxisExpand
		{
			get => GetProperty(ref _rsAxisExpand);
			set => SetProperty(ref _rsAxisExpand, value);
		}

		[Ordinal(12)] 
		[RED("rsAliasingReduction")] 
		public CFloat RsAliasingReduction
		{
			get => GetProperty(ref _rsAliasingReduction);
			set => SetProperty(ref _rsAliasingReduction, value);
		}

		[Ordinal(13)] 
		[RED("bcMergeRange")] 
		public CFloat BcMergeRange
		{
			get => GetProperty(ref _bcMergeRange);
			set => SetProperty(ref _bcMergeRange, value);
		}

		[Ordinal(14)] 
		[RED("bcSizeCutoff")] 
		public CFloat BcSizeCutoff
		{
			get => GetProperty(ref _bcSizeCutoff);
			set => SetProperty(ref _bcSizeCutoff, value);
		}

		[Ordinal(15)] 
		[RED("bcIterations")] 
		public CFloat BcIterations
		{
			get => GetProperty(ref _bcIterations);
			set => SetProperty(ref _bcIterations, value);
		}

		[Ordinal(16)] 
		[RED("bcMaxSize")] 
		public CFloat BcMaxSize
		{
			get => GetProperty(ref _bcMaxSize);
			set => SetProperty(ref _bcMaxSize, value);
		}

		[Ordinal(17)] 
		[RED("bcMinSize")] 
		public CFloat BcMinSize
		{
			get => GetProperty(ref _bcMinSize);
			set => SetProperty(ref _bcMinSize, value);
		}

		[Ordinal(18)] 
		[RED("bcMergeSensitivity")] 
		public CFloat BcMergeSensitivity
		{
			get => GetProperty(ref _bcMergeSensitivity);
			set => SetProperty(ref _bcMergeSensitivity, value);
		}

		[Ordinal(19)] 
		[RED("bcMinScale")] 
		public CFloat BcMinScale
		{
			get => GetProperty(ref _bcMinScale);
			set => SetProperty(ref _bcMinScale, value);
		}

		[Ordinal(20)] 
		[RED("bcGridSize")] 
		public CFloat BcGridSize
		{
			get => GetProperty(ref _bcGridSize);
			set => SetProperty(ref _bcGridSize, value);
		}

		[Ordinal(21)] 
		[RED("bcFilterSensitivity")] 
		public CFloat BcFilterSensitivity
		{
			get => GetProperty(ref _bcFilterSensitivity);
			set => SetProperty(ref _bcFilterSensitivity, value);
		}

		[Ordinal(22)] 
		[RED("bcBoundsRatioLimit")] 
		public CFloat BcBoundsRatioLimit
		{
			get => GetProperty(ref _bcBoundsRatioLimit);
			set => SetProperty(ref _bcBoundsRatioLimit, value);
		}

		[Ordinal(23)] 
		[RED("useClosestPointOnMesh")] 
		public CBool UseClosestPointOnMesh
		{
			get => GetProperty(ref _useClosestPointOnMesh);
			set => SetProperty(ref _useClosestPointOnMesh, value);
		}

		[Ordinal(24)] 
		[RED("removeIslands")] 
		public CBool RemoveIslands
		{
			get => GetProperty(ref _removeIslands);
			set => SetProperty(ref _removeIslands, value);
		}

		[Ordinal(25)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetProperty(ref _backgroundColor);
			set => SetProperty(ref _backgroundColor, value);
		}

		public worldProxyMiscAdvancedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
