using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveAlongPath : IPresetActorLatentAction
	{
		[Ordinal(0)] [RED("("pathTag")] 		public CName PathTag { get; set;}

		[Ordinal(0)] [RED("("upThePath")] 		public CBool UpThePath { get; set;}

		[Ordinal(0)] [RED("("fromBeginning")] 		public CBool FromBeginning { get; set;}

		[Ordinal(0)] [RED("("pathMargin")] 		public CFloat PathMargin { get; set;}

		[Ordinal(0)] [RED("("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(0)] [RED("("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(0)] [RED("("dontCareAboutNavigable")] 		public CBool DontCareAboutNavigable { get; set;}

		public W3ActorLatentActionMoveAlongPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ActorLatentActionMoveAlongPath(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}