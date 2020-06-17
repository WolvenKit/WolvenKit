using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorSetBehaviorVariableDefinition : IBehTreeNodeDecoratorDefinition
	{
		[RED("VarName")] 		public CName VarName { get; set;}

		[RED("setVarActivate")] 		public CBool SetVarActivate { get; set;}

		[RED("valueActivate")] 		public CFloat ValueActivate { get; set;}

		[RED("setVarDeactivate")] 		public CBool SetVarDeactivate { get; set;}

		[RED("valueDeactivate")] 		public CFloat ValueDeactivate { get; set;}

		public CBehTreeDecoratorSetBehaviorVariableDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeDecoratorSetBehaviorVariableDefinition(cr2w);

	}
}