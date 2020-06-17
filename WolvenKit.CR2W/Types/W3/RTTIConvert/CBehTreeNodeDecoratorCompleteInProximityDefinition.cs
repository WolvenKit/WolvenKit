using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorCompleteInProximityDefinition : IBehTreeNodeDecoratorDefinition
	{
		[RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("3D")] 		public CBool _3D { get; set;}

		public CBehTreeNodeDecoratorCompleteInProximityDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeDecoratorCompleteInProximityDefinition(cr2w);

	}
}