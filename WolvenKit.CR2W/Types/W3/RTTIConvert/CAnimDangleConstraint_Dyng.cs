using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Dyng : CAnimSkeletalDangleConstraint
	{
		[RED("dyng")] 		public CHandle<CDyngResource> Dyng { get; set;}

		[RED("animSet")] 		public CHandle<CSkeletalAnimationSet> AnimSet { get; set;}

		[RED("drawlinks")] 		public CBool Drawlinks { get; set;}

		[RED("drawcolls")] 		public CBool Drawcolls { get; set;}

		[RED("drawlimits")] 		public CBool Drawlimits { get; set;}

		[RED("dampening")] 		public CFloat Dampening { get; set;}

		[RED("gravity")] 		public CFloat Gravity { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("planeCollision")] 		public CBool PlaneCollision { get; set;}

		[RED("useOffsets")] 		public CBool UseOffsets { get; set;}

		[RED("shake")] 		public CFloat Shake { get; set;}

		[RED("wind")] 		public CFloat Wind { get; set;}

		[RED("max_links_iterations")] 		public CInt32 Max_links_iterations { get; set;}

		public CAnimDangleConstraint_Dyng(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Dyng(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}