using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDoorComponent : CInteractionComponent
	{
		[Ordinal(1)] [RED("initialState")] 		public CEnum<EDoorState> InitialState { get; set;}

		[Ordinal(2)] [RED("isTrapdoor")] 		public CBool IsTrapdoor { get; set;}

		[Ordinal(3)] [RED("doorsEnebled")] 		public CBool DoorsEnebled { get; set;}

		[Ordinal(4)] [RED("openName")] 		public CString OpenName { get; set;}

		[Ordinal(5)] [RED("closeName")] 		public CString CloseName { get; set;}

		public CDoorComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDoorComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}