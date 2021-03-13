using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemForwardDecal : effectTrackItem
	{
		[Ordinal(3)] [RED("mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(4)] [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(5)] [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
		[Ordinal(6)] [RED("additionalRotation")] public CFloat AdditionalRotation { get; set; }
		[Ordinal(7)] [RED("sizeThreshold")] public CFloat SizeThreshold { get; set; }
		[Ordinal(8)] [RED("randomRotation")] public CBool RandomRotation { get; set; }
		[Ordinal(9)] [RED("randomAppearance")] public CBool RandomAppearance { get; set; }
		[Ordinal(10)] [RED("isAttached")] public CBool IsAttached { get; set; }
		[Ordinal(11)] [RED("subUVx")] public CUInt32 SubUVx { get; set; }
		[Ordinal(12)] [RED("subUVy")] public CUInt32 SubUVy { get; set; }
		[Ordinal(13)] [RED("frame")] public CUInt32 Frame { get; set; }
		[Ordinal(14)] [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
		[Ordinal(15)] [RED("fadeInTime")] public CFloat FadeInTime { get; set; }

		public effectTrackItemForwardDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
