using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVarOnAnimEvent : IBehTreeTask
	{
		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("behVarName")] 		public CName BehVarName { get; set;}

		[RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[RED("eventReceived")] 		public CBool EventReceived { get; set;}

		[RED("onDurationEvent")] 		public CBool OnDurationEvent { get; set;}

		[RED("behValueOnDurationEventStart")] 		public CFloat BehValueOnDurationEventStart { get; set;}

		[RED("behValueOnDurationEventEnd")] 		public CFloat BehValueOnDurationEventEnd { get; set;}

		public CBTTaskSetBehVarOnAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetBehVarOnAnimEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}