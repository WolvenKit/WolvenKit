using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSTableEntry : CVariable
	{
		[RED("comment")] 		public CString Comment { get; set;}

		[RED("entryID")] 		public CString EntryID { get; set;}

		[RED("entities", 2,0)] 		public CArray<CSEntitiesEntry> Entities { get; set;}

		[RED("alwaysSpawned")] 		public CBool AlwaysSpawned { get; set;}

		[RED("storyPhases", 2,0)] 		public CArray<CSStoryPhaseEntry> StoryPhases { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		public CSTableEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSTableEntry(cr2w);

	}
}