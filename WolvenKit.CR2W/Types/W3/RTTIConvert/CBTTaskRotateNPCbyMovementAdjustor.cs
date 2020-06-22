using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRotateNPCbyMovementAdjustor : IBehTreeTask
	{
		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("target")] 		public CHandle<CActor> Target { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("finishTaskOnAllowBlend")] 		public CBool FinishTaskOnAllowBlend { get; set;}

		public CBTTaskRotateNPCbyMovementAdjustor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRotateNPCbyMovementAdjustor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}