using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionalFlagTreeDefinition : IBehTreeMetanodeDefinition
	{
		[RED("child")] 		public CPtr<IBehTreeNodeDefinition> Child { get; set;}

		[RED("val")] 		public CBehTreeValInt Val { get; set;}

		[RED("flag")] 		public CInt32 Flag { get; set;}

		public CBehTreeNodeConditionalFlagTreeDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeConditionalFlagTreeDefinition(cr2w);

	}
}