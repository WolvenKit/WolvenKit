using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldProxyMiscAdvancedParams : CVariable
	{
		[Ordinal(0)]  [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(1)]  [RED("bcBoundsRatioLimit")] public CFloat BcBoundsRatioLimit { get; set; }
		[Ordinal(2)]  [RED("bcFilterSensitivity")] public CFloat BcFilterSensitivity { get; set; }
		[Ordinal(3)]  [RED("bcGridSize")] public CFloat BcGridSize { get; set; }
		[Ordinal(4)]  [RED("bcIterations")] public CFloat BcIterations { get; set; }
		[Ordinal(5)]  [RED("bcMaxSize")] public CFloat BcMaxSize { get; set; }
		[Ordinal(6)]  [RED("bcMergeRange")] public CFloat BcMergeRange { get; set; }
		[Ordinal(7)]  [RED("bcMergeSensitivity")] public CFloat BcMergeSensitivity { get; set; }
		[Ordinal(8)]  [RED("bcMinScale")] public CFloat BcMinScale { get; set; }
		[Ordinal(9)]  [RED("bcMinSize")] public CFloat BcMinSize { get; set; }
		[Ordinal(10)]  [RED("bcSizeCutoff")] public CFloat BcSizeCutoff { get; set; }
		[Ordinal(11)]  [RED("blurCutout")] public CUInt8 BlurCutout { get; set; }
		[Ordinal(12)]  [RED("capBottom")] public CBool CapBottom { get; set; }
		[Ordinal(13)]  [RED("capTop")] public CBool CapTop { get; set; }
		[Ordinal(14)]  [RED("fillHolesAfterReduceRatio")] public CFloat FillHolesAfterReduceRatio { get; set; }
		[Ordinal(15)]  [RED("fillHolesBeforeReduceRatio")] public CFloat FillHolesBeforeReduceRatio { get; set; }
		[Ordinal(16)]  [RED("occlusionRatio")] public CUInt8 OcclusionRatio { get; set; }
		[Ordinal(17)]  [RED("removeIslands")] public CBool RemoveIslands { get; set; }
		[Ordinal(18)]  [RED("rsAliasingReduction")] public CFloat RsAliasingReduction { get; set; }
		[Ordinal(19)]  [RED("rsAxisExpand")] public Vector3 RsAxisExpand { get; set; }
		[Ordinal(20)]  [RED("rsAxisPrecision")] public Vector3 RsAxisPrecision { get; set; }
		[Ordinal(21)]  [RED("rsDetailDrop")] public CFloat RsDetailDrop { get; set; }
		[Ordinal(22)]  [RED("rsSweepOrder")] public CInt32 RsSweepOrder { get; set; }
		[Ordinal(23)]  [RED("smoothVolume")] public CBool SmoothVolume { get; set; }
		[Ordinal(24)]  [RED("useClosestPointOnMesh")] public CBool UseClosestPointOnMesh { get; set; }
		[Ordinal(25)]  [RED("useLod1")] public CBool UseLod1 { get; set; }

		public worldProxyMiscAdvancedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
