using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAttitudeDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("towardsActionTarget")] 		public CBool TowardsActionTarget { get; set;}

		[Ordinal(2)] [RED("gameplayEventName")] 		public CBehTreeValCName GameplayEventName { get; set;}

		[Ordinal(3)] [RED("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		public CBTTaskSetAttitudeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetAttitudeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}