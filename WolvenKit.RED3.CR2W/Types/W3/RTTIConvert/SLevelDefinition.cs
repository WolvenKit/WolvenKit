using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLevelDefinition : CVariable
	{
		[Ordinal(1)] [RED("number")] 		public CInt32 Number { get; set;}

		[Ordinal(2)] [RED("requiredTotalExp")] 		public CInt32 RequiredTotalExp { get; set;}

		[Ordinal(3)] [RED("addedSkillPoints")] 		public CInt32 AddedSkillPoints { get; set;}

		[Ordinal(4)] [RED("requiredExp")] 		public CInt32 RequiredExp { get; set;}

		public SLevelDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLevelDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}