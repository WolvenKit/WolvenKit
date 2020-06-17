using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDynamicWanderingTargetDefinition : CBehTreeNodeSelectWanderingTargetDecoratorDefinition
	{
		[RED("dynamicWanderAreaName_var")] 		public CName DynamicWanderAreaName_var { get; set;}

		[RED("minimalWanderDistance")] 		public CBehTreeValFloat MinimalWanderDistance { get; set;}

		[RED("useGuardArea")] 		public CBehTreeValBool UseGuardArea { get; set;}

		public CBehTreeNodeDynamicWanderingTargetDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeDynamicWanderingTargetDefinition(cr2w);

	}
}