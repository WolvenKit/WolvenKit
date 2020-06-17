using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveAlongPathWithCompanion : W3ActorLatentActionMoveAlongPath
	{
		[RED("companionTag")] 		public CName CompanionTag { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("progressWhenCompanionIsAhead")] 		public CBool ProgressWhenCompanionIsAhead { get; set;}

		public W3ActorLatentActionMoveAlongPathWithCompanion(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ActorLatentActionMoveAlongPathWithCompanion(cr2w);

	}
}