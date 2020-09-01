using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMiscreantCrying : IBehTreeTask
	{
		[Ordinal(0)] [RED("miscreantName")] 		public CName MiscreantName { get; set;}

		[Ordinal(0)] [RED("miscreant")] 		public CHandle<CActor> Miscreant { get; set;}

		[Ordinal(0)] [RED("isAvailable")] 		public CBool IsAvailable { get; set;}

		[Ordinal(0)] [RED("cryStartEventName")] 		public CName CryStartEventName { get; set;}

		[Ordinal(0)] [RED("cryStopEventName")] 		public CName CryStopEventName { get; set;}

		public CBTTaskMiscreantCrying(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMiscreantCrying(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}