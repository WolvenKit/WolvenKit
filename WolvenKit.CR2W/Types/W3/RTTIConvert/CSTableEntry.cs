using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSTableEntry : CVariable
	{
		[Ordinal(0)] [RED("("comment")] 		public CString Comment { get; set;}

		[Ordinal(0)] [RED("("entryID")] 		public CString EntryID { get; set;}

		[Ordinal(0)] [RED("("entities", 2,0)] 		public CArray<CSEntitiesEntry> Entities { get; set;}

		[Ordinal(0)] [RED("("alwaysSpawned")] 		public CBool AlwaysSpawned { get; set;}

		[Ordinal(0)] [RED("("storyPhases", 2,0)] 		public CArray<CSStoryPhaseEntry> StoryPhases { get; set;}

		[Ordinal(0)] [RED("("guid")] 		public CGUID Guid { get; set;}

		public CSTableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSTableEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}