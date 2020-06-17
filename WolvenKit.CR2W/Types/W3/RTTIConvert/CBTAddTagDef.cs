using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTAddTagDef : IBehTreeTaskDefinition
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("toOwner")] 		public CBool ToOwner { get; set;}

		[RED("toTarget")] 		public CBool ToTarget { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		public CBTAddTagDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTAddTagDef(cr2w);

	}
}