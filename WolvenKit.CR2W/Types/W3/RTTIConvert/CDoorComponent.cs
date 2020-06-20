using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDoorComponent : CInteractionComponent
	{
		[RED("initialState")] 		public CEnum<EDoorState> InitialState { get; set;}

		[RED("isTrapdoor")] 		public CBool IsTrapdoor { get; set;}

		[RED("doorsEnebled")] 		public CBool DoorsEnebled { get; set;}

		[RED("openName")] 		public CString OpenName { get; set;}

		[RED("closeName")] 		public CString CloseName { get; set;}

		public CDoorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDoorComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}