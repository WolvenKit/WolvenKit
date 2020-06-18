using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveAlongPath : IPresetActorLatentAction
	{
		[RED("pathTag")] 		public CName PathTag { get; set;}

		[RED("upThePath")] 		public CBool UpThePath { get; set;}

		[RED("fromBeginning")] 		public CBool FromBeginning { get; set;}

		[RED("pathMargin")] 		public CFloat PathMargin { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("dontCareAboutNavigable")] 		public CBool DontCareAboutNavigable { get; set;}

		public W3ActorLatentActionMoveAlongPath(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ActorLatentActionMoveAlongPath(cr2w);

	}
}