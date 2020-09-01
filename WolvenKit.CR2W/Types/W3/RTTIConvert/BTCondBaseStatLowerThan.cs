using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondBaseStatLowerThan : IBehTreeTask
	{
		[Ordinal(0)] [RED("("checkedActor")] 		public CEnum<EStatOwner> CheckedActor { get; set;}

		[Ordinal(0)] [RED("("baseStatType")] 		public CEnum<EBaseCharacterStats> BaseStatType { get; set;}

		[Ordinal(0)] [RED("("statValue")] 		public CFloat StatValue { get; set;}

		[Ordinal(0)] [RED("("percentage")] 		public CBool Percentage { get; set;}

		[Ordinal(0)] [RED("("ifNot")] 		public CBool IfNot { get; set;}

		public BTCondBaseStatLowerThan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondBaseStatLowerThan(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}