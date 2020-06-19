using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorCarryingItemsBaseDefinition : IBehTreeNodeDecoratorDefinition
	{
		[RED("carryingAreaName_var")] 		public CName CarryingAreaName_var { get; set;}

		[RED("storeTag")] 		public CBehTreeValCName StoreTag { get; set;}

		public CBehTreeDecoratorCarryingItemsBaseDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeDecoratorCarryingItemsBaseDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}