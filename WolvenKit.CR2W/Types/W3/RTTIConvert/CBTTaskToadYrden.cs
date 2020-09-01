using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadYrden : IBehTreeTask
	{
		[Ordinal(1)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("("leftYrden")] 		public CBool LeftYrden { get; set;}

		[Ordinal(3)] [RED("("leaveAfter")] 		public CFloat LeaveAfter { get; set;}

		[Ordinal(4)] [RED("("enterTimestamp")] 		public CFloat EnterTimestamp { get; set;}

		[Ordinal(5)] [RED("("l_effect")] 		public CBool L_effect { get; set;}

		public CBTTaskToadYrden(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskToadYrden(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}