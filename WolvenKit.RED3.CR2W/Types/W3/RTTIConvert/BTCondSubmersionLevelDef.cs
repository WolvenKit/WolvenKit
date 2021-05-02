using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondSubmersionLevelDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("checkedActor")] 		public CEnum<EStatOwner> CheckedActor { get; set;}

		[Ordinal(2)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(3)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		public BTCondSubmersionLevelDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondSubmersionLevelDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}