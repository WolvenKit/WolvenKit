using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondIsInBehaviorGraphNodeDef : IBehTreeConditionalTaskDefinition
	{
		[RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[RED("deactivateScriptEvent")] 		public CName DeactivateScriptEvent { get; set;}

		public BTCondIsInBehaviorGraphNodeDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondIsInBehaviorGraphNodeDef(cr2w);

	}
}