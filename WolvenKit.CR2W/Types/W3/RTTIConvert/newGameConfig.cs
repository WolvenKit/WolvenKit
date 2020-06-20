using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class newGameConfig : CVariable
	{
		[RED("tutorialsOn")] 		public CBool TutorialsOn { get; set;}

		[RED("difficulty")] 		public CInt32 Difficulty { get; set;}

		[RED("simulate_import")] 		public CBool Simulate_import { get; set;}

		[RED("import_save_index")] 		public CInt32 Import_save_index { get; set;}

		public newGameConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new newGameConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}