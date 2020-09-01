using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Dyng : CAnimSkeletalDangleConstraint
	{
		[Ordinal(0)] [RED("dyng")] 		public CHandle<CDyngResource> Dyng { get; set;}

		[Ordinal(0)] [RED("animSet")] 		public CHandle<CSkeletalAnimationSet> AnimSet { get; set;}

		[Ordinal(0)] [RED("drawlinks")] 		public CBool Drawlinks { get; set;}

		[Ordinal(0)] [RED("drawcolls")] 		public CBool Drawcolls { get; set;}

		[Ordinal(0)] [RED("drawlimits")] 		public CBool Drawlimits { get; set;}

		[Ordinal(0)] [RED("dampening")] 		public CFloat Dampening { get; set;}

		[Ordinal(0)] [RED("gravity")] 		public CFloat Gravity { get; set;}

		[Ordinal(0)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("planeCollision")] 		public CBool PlaneCollision { get; set;}

		[Ordinal(0)] [RED("useOffsets")] 		public CBool UseOffsets { get; set;}

		[Ordinal(0)] [RED("shake")] 		public CFloat Shake { get; set;}

		[Ordinal(0)] [RED("wind")] 		public CFloat Wind { get; set;}

		[Ordinal(0)] [RED("max_links_iterations")] 		public CInt32 Max_links_iterations { get; set;}

		public CAnimDangleConstraint_Dyng(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Dyng(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}