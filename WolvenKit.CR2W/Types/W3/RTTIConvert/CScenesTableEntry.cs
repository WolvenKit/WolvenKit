using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScenesTableEntry : CVariable
	{
		[RED("sceneFile")] 		public CSoft<CStoryScene> SceneFile { get; set;}

		[RED("sceneInput")] 		public CString SceneInput { get; set;}

		[RED("requiredFact")] 		public CString RequiredFact { get; set;}

		[RED("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		public CScenesTableEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CScenesTableEntry(cr2w);

	}
}