using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorChangeBehaviorGraphDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(0)] [RED("behGraphNameActivate")] 		public CBehTreeValCName BehGraphNameActivate { get; set;}

		[Ordinal(0)] [RED("behGraphNameDeactivate")] 		public CBehTreeValCName BehGraphNameDeactivate { get; set;}

		[Ordinal(0)] [RED("activateIfBehaviorUnavailable")] 		public CBool ActivateIfBehaviorUnavailable { get; set;}

		public CBehTreeDecoratorChangeBehaviorGraphDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeDecoratorChangeBehaviorGraphDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}