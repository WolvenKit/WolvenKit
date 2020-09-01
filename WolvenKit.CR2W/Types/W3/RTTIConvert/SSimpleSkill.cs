using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSimpleSkill : CVariable
	{
		[Ordinal(1)] [RED("("level")] 		public CInt32 Level { get; set;}

		[Ordinal(2)] [RED("("skillType")] 		public CEnum<ESkill> SkillType { get; set;}

		public SSimpleSkill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSimpleSkill(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}