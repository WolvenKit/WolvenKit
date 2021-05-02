using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDynamicNodeDefinition : IBehTreeDynamicNodeBaseDefinition
	{
		[Ordinal(1)] [RED("dynamicEventName")] 		public CName DynamicEventName { get; set;}

		[Ordinal(2)] [RED("baseTreeVar")] 		public CName BaseTreeVar { get; set;}

		[Ordinal(3)] [RED("baseTree")] 		public CHandle<CAITree> BaseTree { get; set;}

		public CBehTreeDynamicNodeDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeDynamicNodeDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}