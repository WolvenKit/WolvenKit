using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnSlidingEntity : CBTTaskSpawnEntityOffset
	{
		[Ordinal(1)] [RED("component")] 		public CHandle<CComponent> Component { get; set;}

		[Ordinal(2)] [RED("slideComponent")] 		public CHandle<W3SlideToTargetComponent> SlideComponent { get; set;}

		[Ordinal(3)] [RED("targetNode")] 		public CHandle<CNode> TargetNode { get; set;}

		[Ordinal(4)] [RED("timeToFollow")] 		public CInt32 TimeToFollow { get; set;}

		[Ordinal(5)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(6)] [RED("destroyAfter")] 		public CFloat DestroyAfter { get; set;}

		[Ordinal(7)] [RED("destroyAfterTimerEnds")] 		public CBool DestroyAfterTimerEnds { get; set;}

		[Ordinal(8)] [RED("destroyOnDeactivate")] 		public CBool DestroyOnDeactivate { get; set;}

		public CBTTaskSpawnSlidingEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnSlidingEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}