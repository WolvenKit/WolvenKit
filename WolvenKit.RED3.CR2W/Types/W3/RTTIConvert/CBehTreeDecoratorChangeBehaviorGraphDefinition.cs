using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorChangeBehaviorGraphDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("behGraphNameActivate")] 		public CBehTreeValCName BehGraphNameActivate { get; set;}

		[Ordinal(2)] [RED("behGraphNameDeactivate")] 		public CBehTreeValCName BehGraphNameDeactivate { get; set;}

		[Ordinal(3)] [RED("activateIfBehaviorUnavailable")] 		public CBool ActivateIfBehaviorUnavailable { get; set;}

		public CBehTreeDecoratorChangeBehaviorGraphDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeDecoratorChangeBehaviorGraphDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}