using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVarOnAnimEventDef : IBehTreeTaskDefinition
	{
		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("behVarName")] 		public CName BehVarName { get; set;}

		[RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[RED("onDurationEvent")] 		public CBool OnDurationEvent { get; set;}

		[RED("behValueOnDurationEventStart")] 		public CFloat BehValueOnDurationEventStart { get; set;}

		[RED("behValueOnDurationEventEnd")] 		public CFloat BehValueOnDurationEventEnd { get; set;}

		public CBTTaskSetBehVarOnAnimEventDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSetBehVarOnAnimEventDef(cr2w);

	}
}