using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveAlongPathAwareOfTail : W3ActorLatentActionMoveAlongPath
	{
		[RED("tailTag")] 		public CName TailTag { get; set;}

		[RED("startMovementDistance")] 		public CFloat StartMovementDistance { get; set;}

		[RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		public W3ActorLatentActionMoveAlongPathAwareOfTail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ActorLatentActionMoveAlongPathAwareOfTail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}