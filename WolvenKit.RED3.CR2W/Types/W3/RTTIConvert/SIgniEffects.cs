using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SIgniEffects : CVariable
	{
		[Ordinal(1)] [RED("throwEffect")] 		public CName ThrowEffect { get; set;}

		[Ordinal(2)] [RED("forestEffect")] 		public CName ForestEffect { get; set;}

		[Ordinal(3)] [RED("upgradedThrowEffect")] 		public CName UpgradedThrowEffect { get; set;}

		[Ordinal(4)] [RED("meltArmorEffect")] 		public CName MeltArmorEffect { get; set;}

		[Ordinal(5)] [RED("combustibleEffect")] 		public CName CombustibleEffect { get; set;}

		[Ordinal(6)] [RED("throwEffectSpellPower")] 		public CName ThrowEffectSpellPower { get; set;}

		public SIgniEffects(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SIgniEffects(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}