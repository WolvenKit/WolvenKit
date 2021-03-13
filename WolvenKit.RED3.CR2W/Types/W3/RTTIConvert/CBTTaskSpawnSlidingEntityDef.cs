using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnSlidingEntityDef : CBTTaskSpawnEntityOffsetDef
	{
		[Ordinal(1)] [RED("slideComponent")] 		public CHandle<W3SlideToTargetComponent> SlideComponent { get; set;}

		[Ordinal(2)] [RED("targetNode")] 		public CHandle<CNode> TargetNode { get; set;}

		[Ordinal(3)] [RED("timeToFollow")] 		public CInt32 TimeToFollow { get; set;}

		[Ordinal(4)] [RED("destroyAfter")] 		public CFloat DestroyAfter { get; set;}

		[Ordinal(5)] [RED("destroyAfterTimerEnds")] 		public CBool DestroyAfterTimerEnds { get; set;}

		[Ordinal(6)] [RED("destroyOnDeactivate")] 		public CBool DestroyOnDeactivate { get; set;}

		public CBTTaskSpawnSlidingEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnSlidingEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}