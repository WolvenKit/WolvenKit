using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSyncAttackTypes : CVariable
	{
		[RED("leftStanceFrontAttack")] 		public CEnum<EAttackType> LeftStanceFrontAttack { get; set;}

		[RED("rightStanceFrontAttack")] 		public CEnum<EAttackType> RightStanceFrontAttack { get; set;}

		[RED("leftStanceBackAttack")] 		public CEnum<EAttackType> LeftStanceBackAttack { get; set;}

		[RED("rightStanceBackAttack")] 		public CEnum<EAttackType> RightStanceBackAttack { get; set;}

		public SSyncAttackTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSyncAttackTypes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}