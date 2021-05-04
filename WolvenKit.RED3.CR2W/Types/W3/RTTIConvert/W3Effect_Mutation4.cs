using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Mutation4 : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("bonusPerPoint")] 		public CFloat BonusPerPoint { get; set;}

		[Ordinal(2)] [RED("dotDuration")] 		public CFloat DotDuration { get; set;}

		public W3Effect_Mutation4(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}