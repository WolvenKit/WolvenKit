using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskExplodeAtDeathDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("requiredAbility")] 		public CName RequiredAbility { get; set;}

		[Ordinal(2)] [RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(3)] [RED("damageValue")] 		public CFloat DamageValue { get; set;}

		[Ordinal(4)] [RED("weaponSlot")] 		public CName WeaponSlot { get; set;}

		public BTTaskExplodeAtDeathDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskExplodeAtDeathDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}