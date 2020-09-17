using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeRequestItemsDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("LeftItemType")] 		public CBehTreeValCName LeftItemType { get; set;}

		[Ordinal(2)] [RED("RightItemType")] 		public CBehTreeValCName RightItemType { get; set;}

		[Ordinal(3)] [RED("chooseSilverIfPossible")] 		public CBehTreeValBool ChooseSilverIfPossible { get; set;}

		[Ordinal(4)] [RED("behaviorGraphVarName")] 		public CName BehaviorGraphVarName { get; set;}

		public CBehTreeNodeRequestItemsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeRequestItemsDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}