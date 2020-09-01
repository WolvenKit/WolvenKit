using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScenesTableEntry : CVariable
	{
		[Ordinal(1)] [RED("("sceneFile")] 		public CSoft<CStoryScene> SceneFile { get; set;}

		[Ordinal(2)] [RED("("sceneInput")] 		public CString SceneInput { get; set;}

		[Ordinal(3)] [RED("("requiredFact")] 		public CString RequiredFact { get; set;}

		[Ordinal(4)] [RED("("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		public CScenesTableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CScenesTableEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}