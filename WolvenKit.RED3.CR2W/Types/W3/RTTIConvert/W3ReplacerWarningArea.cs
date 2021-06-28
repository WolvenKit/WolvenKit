using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReplacerWarningArea : CEntity
	{
		[Ordinal(1)] [RED("messageKey")] 		public CString MessageKey { get; set;}

		[Ordinal(2)] [RED("messageInterval")] 		public CFloat MessageInterval { get; set;}

		[Ordinal(3)] [RED("invertLogic")] 		public CBool InvertLogic { get; set;}

		[Ordinal(4)] [RED("isPlayerInArea")] 		public CBool IsPlayerInArea { get; set;}

		public W3ReplacerWarningArea(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}