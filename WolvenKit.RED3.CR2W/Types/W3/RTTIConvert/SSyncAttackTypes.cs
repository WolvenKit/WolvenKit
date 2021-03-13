using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSyncAttackTypes : CVariable
	{
		[Ordinal(1)] [RED("leftStanceFrontAttack")] 		public CEnum<EAttackType> LeftStanceFrontAttack { get; set;}

		[Ordinal(2)] [RED("rightStanceFrontAttack")] 		public CEnum<EAttackType> RightStanceFrontAttack { get; set;}

		[Ordinal(3)] [RED("leftStanceBackAttack")] 		public CEnum<EAttackType> LeftStanceBackAttack { get; set;}

		[Ordinal(4)] [RED("rightStanceBackAttack")] 		public CEnum<EAttackType> RightStanceBackAttack { get; set;}

		public SSyncAttackTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSyncAttackTypes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}