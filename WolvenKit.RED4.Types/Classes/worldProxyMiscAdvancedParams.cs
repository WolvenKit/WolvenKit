using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyMiscAdvancedParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("useLod1")] 
		public CBool UseLod1
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("smoothVolume")] 
		public CBool SmoothVolume
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("blurCutout")] 
		public CUInt8 BlurCutout
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("occlusionRatio")] 
		public CUInt8 OcclusionRatio
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("capTop")] 
		public CBool CapTop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("capBottom")] 
		public CBool CapBottom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("fillHolesBeforeReduceRatio")] 
		public CFloat FillHolesBeforeReduceRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("fillHolesAfterReduceRatio")] 
		public CFloat FillHolesAfterReduceRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("rsSweepOrder")] 
		public CInt32 RsSweepOrder
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("rsDetailDrop")] 
		public CFloat RsDetailDrop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("rsAxisPrecision")] 
		public Vector3 RsAxisPrecision
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(11)] 
		[RED("rsAxisExpand")] 
		public Vector3 RsAxisExpand
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(12)] 
		[RED("rsAliasingReduction")] 
		public CFloat RsAliasingReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("bcMergeRange")] 
		public CFloat BcMergeRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("bcSizeCutoff")] 
		public CFloat BcSizeCutoff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("bcIterations")] 
		public CFloat BcIterations
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("bcMaxSize")] 
		public CFloat BcMaxSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("bcMinSize")] 
		public CFloat BcMinSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("bcMergeSensitivity")] 
		public CFloat BcMergeSensitivity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("bcMinScale")] 
		public CFloat BcMinScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("bcGridSize")] 
		public CFloat BcGridSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("bcFilterSensitivity")] 
		public CFloat BcFilterSensitivity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("bcBoundsRatioLimit")] 
		public CFloat BcBoundsRatioLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("useClosestPointOnMesh")] 
		public CBool UseClosestPointOnMesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("removeIslands")] 
		public CBool RemoveIslands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldProxyMiscAdvancedParams()
		{
			UseLod1 = true;
			BlurCutout = 20;
			OcclusionRatio = 40;
			FillHolesBeforeReduceRatio = 1.500000F;
			FillHolesAfterReduceRatio = 0.400000F;
			RsAxisPrecision = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			RsAxisExpand = new();
			RsAliasingReduction = 1.000000F;
			BcMergeRange = 0.800000F;
			BcSizeCutoff = 120.000000F;
			BcIterations = 0.500000F;
			BcMaxSize = 120.000000F;
			BcMinSize = 2.000000F;
			BcMergeSensitivity = 50.000000F;
			BcMinScale = 1.000000F;
			BcGridSize = 120.000000F;
			BcFilterSensitivity = 0.250000F;
			BcBoundsRatioLimit = 0.250000F;
			RemoveIslands = true;
			BackgroundColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
