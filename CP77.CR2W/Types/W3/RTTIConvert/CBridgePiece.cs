using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBridgePiece : CScriptedDestroyableComponent
	{
		[Ordinal(1)] [RED("entityPos")] 		public Vector EntityPos { get; set;}

		[Ordinal(2)] [RED("compPos")] 		public Vector CompPos { get; set;}

		[Ordinal(3)] [RED("totalTime")] 		public CFloat TotalTime { get; set;}

		[Ordinal(4)] [RED("z")] 		public CHandle<CEntity> Z { get; set;}

		public CBridgePiece(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBridgePiece(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}