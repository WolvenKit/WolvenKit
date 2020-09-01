using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiHotkeyHelp : CVariable
	{
		[Ordinal(1)] [RED("("action")] 		public CName Action { get; set;}

		[Ordinal(2)] [RED("("help")] 		public CString Help { get; set;}

		public SModUiHotkeyHelp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SModUiHotkeyHelp(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}