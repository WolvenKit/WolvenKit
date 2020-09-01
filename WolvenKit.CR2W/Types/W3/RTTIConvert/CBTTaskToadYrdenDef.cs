using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadYrdenDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("npc")] 		public CHandle<CActor> Npc { get; set;}

		[Ordinal(0)] [RED("("leftYrden")] 		public CBool LeftYrden { get; set;}

		[Ordinal(0)] [RED("("leaveAfter")] 		public CFloat LeaveAfter { get; set;}

		[Ordinal(0)] [RED("("enterTimestamp")] 		public CFloat EnterTimestamp { get; set;}

		[Ordinal(0)] [RED("("l_effect")] 		public CBool L_effect { get; set;}

		public CBTTaskToadYrdenDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskToadYrdenDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}