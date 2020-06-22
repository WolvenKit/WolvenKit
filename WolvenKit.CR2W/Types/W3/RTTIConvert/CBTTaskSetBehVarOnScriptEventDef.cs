using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVarOnScriptEventDef : IBehTreeTaskDefinition
	{
		[RED("activationEventName")] 		public CName ActivationEventName { get; set;}

		[RED("behVarName")] 		public CName BehVarName { get; set;}

		[RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[RED("delay")] 		public CFloat Delay { get; set;}

		[RED("previousValueOnDurationEnd")] 		public CBool PreviousValueOnDurationEnd { get; set;}

		public CBTTaskSetBehVarOnScriptEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetBehVarOnScriptEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}