using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveAlongPath : IPresetActorLatentAction
	{
		[Ordinal(1)] [RED("pathTag")] 		public CName PathTag { get; set;}

		[Ordinal(2)] [RED("upThePath")] 		public CBool UpThePath { get; set;}

		[Ordinal(3)] [RED("fromBeginning")] 		public CBool FromBeginning { get; set;}

		[Ordinal(4)] [RED("pathMargin")] 		public CFloat PathMargin { get; set;}

		[Ordinal(5)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(6)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(7)] [RED("dontCareAboutNavigable")] 		public CBool DontCareAboutNavigable { get; set;}

		public W3ActorLatentActionMoveAlongPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ActorLatentActionMoveAlongPath(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}