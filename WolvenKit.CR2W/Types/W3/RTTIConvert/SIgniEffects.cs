using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SIgniEffects : CVariable
	{
		[RED("throwEffect")] 		public CName ThrowEffect { get; set;}

		[RED("forestEffect")] 		public CName ForestEffect { get; set;}

		[RED("upgradedThrowEffect")] 		public CName UpgradedThrowEffect { get; set;}

		[RED("meltArmorEffect")] 		public CName MeltArmorEffect { get; set;}

		[RED("combustibleEffect")] 		public CName CombustibleEffect { get; set;}

		[RED("throwEffectSpellPower")] 		public CName ThrowEffectSpellPower { get; set;}

		public SIgniEffects(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SIgniEffects(cr2w);

	}
}