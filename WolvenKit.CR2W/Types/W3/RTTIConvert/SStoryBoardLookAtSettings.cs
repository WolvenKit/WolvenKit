using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardLookAtSettings : CVariable
	{
		[Ordinal(0)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("("lookAtActor")] 		public CString LookAtActor { get; set;}

		[Ordinal(0)] [RED("("rot")] 		public EulerAngles Rot { get; set;}

		public SStoryBoardLookAtSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardLookAtSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}