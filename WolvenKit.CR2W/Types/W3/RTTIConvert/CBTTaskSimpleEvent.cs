using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSimpleEvent : IBehTreeTask
	{
		[Ordinal(1)] [RED("("available")] 		public CBool Available { get; set;}

		[Ordinal(2)] [RED("("Delay")] 		public CFloat Delay { get; set;}

		[Ordinal(3)] [RED("("Event")] 		public CName Event { get; set;}

		public CBTTaskSimpleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSimpleEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}