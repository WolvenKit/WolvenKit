using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateDye : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("DYE")] 		public CName DYE { get; set;}

		[Ordinal(2)] [RED("DYE2")] 		public CName DYE2 { get; set;}

		[Ordinal(3)] [RED("DYE_REMOVER")] 		public CName DYE_REMOVER { get; set;}

		[Ordinal(4)] [RED("DYE_PREVIEW")] 		public CName DYE_PREVIEW { get; set;}

		[Ordinal(5)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateDye(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}