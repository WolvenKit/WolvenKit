using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondIsInGuardAreaDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("position")] 		public CEnum<ETargetName> Position { get; set;}

		[Ordinal(2)] [RED("namedTarget")] 		public CName NamedTarget { get; set;}

		[Ordinal(3)] [RED("valueToReturnIfNoGA")] 		public CBool ValueToReturnIfNoGA { get; set;}

		public BTCondIsInGuardAreaDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondIsInGuardAreaDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}