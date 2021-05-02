using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRotateNPCbyMovementAdjustorDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(3)] [RED("active")] 		public CBool Active { get; set;}

		[Ordinal(4)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(5)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(6)] [RED("finishTaskOnAllowBlend")] 		public CBool FinishTaskOnAllowBlend { get; set;}

		public CBTTaskRotateNPCbyMovementAdjustorDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRotateNPCbyMovementAdjustorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}