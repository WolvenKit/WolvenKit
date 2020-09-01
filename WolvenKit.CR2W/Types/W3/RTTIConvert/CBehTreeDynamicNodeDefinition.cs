using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDynamicNodeDefinition : IBehTreeDynamicNodeBaseDefinition
	{
		[Ordinal(0)] [RED("dynamicEventName")] 		public CName DynamicEventName { get; set;}

		[Ordinal(0)] [RED("baseTreeVar")] 		public CName BaseTreeVar { get; set;}

		[Ordinal(0)] [RED("baseTree")] 		public CHandle<CAITree> BaseTree { get; set;}

		public CBehTreeDynamicNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeDynamicNodeDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}