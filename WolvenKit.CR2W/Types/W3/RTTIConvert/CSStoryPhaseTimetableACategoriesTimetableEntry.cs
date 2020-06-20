using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSStoryPhaseTimetableACategoriesTimetableEntry : CVariable
	{
		[RED("time")] 		public GameTime Time { get; set;}

		[RED("actions", 2,0)] 		public CArray<CSStoryPhaseTimetableActionEntry> Actions { get; set;}

		public CSStoryPhaseTimetableACategoriesTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSStoryPhaseTimetableACategoriesTimetableEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}