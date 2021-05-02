using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTAddTagDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("toOwner")] 		public CBool ToOwner { get; set;}

		[Ordinal(3)] [RED("toTarget")] 		public CBool ToTarget { get; set;}

		[Ordinal(4)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(5)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(6)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		public CBTAddTagDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}