using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskActivateMagicBubbleDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("resourceName")] 		public CBehTreeValCName ResourceName { get; set;}

		[Ordinal(2)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(3)] [RED("animEventName")] 		public CName AnimEventName { get; set;}

		public CBTTaskActivateMagicBubbleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskActivateMagicBubbleDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}