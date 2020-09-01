using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWaitForDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("waitForTag")] 		public CBehTreeValCName WaitForTag { get; set;}

		[Ordinal(0)] [RED("("timeout")] 		public CBehTreeValFloat Timeout { get; set;}

		[Ordinal(0)] [RED("("testDistance")] 		public CBehTreeValFloat TestDistance { get; set;}

		public CBTTaskWaitForDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWaitForDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}