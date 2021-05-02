using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveAlongPathWithCompanion : W3ActorLatentActionMoveAlongPath
	{
		[Ordinal(1)] [RED("companionTag")] 		public CName CompanionTag { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(4)] [RED("progressWhenCompanionIsAhead")] 		public CBool ProgressWhenCompanionIsAhead { get; set;}

		public W3ActorLatentActionMoveAlongPathWithCompanion(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ActorLatentActionMoveAlongPathWithCompanion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}