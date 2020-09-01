using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionalFlagTreeDefinition : IBehTreeMetanodeDefinition
	{
		[Ordinal(1)] [RED("child")] 		public CPtr<IBehTreeNodeDefinition> Child { get; set;}

		[Ordinal(2)] [RED("val")] 		public CBehTreeValInt Val { get; set;}

		[Ordinal(3)] [RED("flag")] 		public CInt32 Flag { get; set;}

		public CBehTreeNodeConditionalFlagTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeConditionalFlagTreeDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}