using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLevelDefinition : CVariable
	{
		[Ordinal(1)] [RED("("number")] 		public CInt32 Number { get; set;}

		[Ordinal(2)] [RED("("requiredTotalExp")] 		public CInt32 RequiredTotalExp { get; set;}

		[Ordinal(3)] [RED("("addedSkillPoints")] 		public CInt32 AddedSkillPoints { get; set;}

		[Ordinal(4)] [RED("("requiredExp")] 		public CInt32 RequiredExp { get; set;}

		public SLevelDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLevelDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}