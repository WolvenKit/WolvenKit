using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorCarryingItemsBaseDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("carryingAreaName_var")] 		public CName CarryingAreaName_var { get; set;}

		[Ordinal(2)] [RED("storeTag")] 		public CBehTreeValCName StoreTag { get; set;}

		public CBehTreeDecoratorCarryingItemsBaseDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}