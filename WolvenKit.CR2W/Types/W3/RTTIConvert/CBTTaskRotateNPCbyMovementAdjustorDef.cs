using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRotateNPCbyMovementAdjustorDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(0)] [RED("("active")] 		public CBool Active { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("eventName")] 		public CName EventName { get; set;}

		[Ordinal(0)] [RED("("finishTaskOnAllowBlend")] 		public CBool FinishTaskOnAllowBlend { get; set;}

		public CBTTaskRotateNPCbyMovementAdjustorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRotateNPCbyMovementAdjustorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}