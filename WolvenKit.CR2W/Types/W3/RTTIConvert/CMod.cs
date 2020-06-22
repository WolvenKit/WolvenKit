using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMod : CObject
	{
		[RED("modName")] 		public CName ModName { get; set;}

		[RED("modVersion")] 		public CName ModVersion { get; set;}

		[RED("modAuthor")] 		public CString ModAuthor { get; set;}

		[RED("modUrl")] 		public CString ModUrl { get; set;}

		[RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[RED("logLevel")] 		public CEnum<EModLogLevel> LogLevel { get; set;}

		public CMod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMod(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}