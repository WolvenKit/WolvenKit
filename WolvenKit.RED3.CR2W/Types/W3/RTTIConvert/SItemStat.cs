using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemStat : CVariable
	{
		[Ordinal(1)] [RED("statType")] 		public CName StatType { get; set;}

		[Ordinal(2)] [RED("statWeight")] 		public CFloat StatWeight { get; set;}

		[Ordinal(3)] [RED("statIsPercentage")] 		public CBool StatIsPercentage { get; set;}

		public SItemStat(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}