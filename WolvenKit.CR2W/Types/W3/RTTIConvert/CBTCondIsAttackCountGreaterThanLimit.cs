using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondIsAttackCountGreaterThanLimit : IBehTreeTask
	{
		[RED("combatDataStorage")] 		public CHandle<CExtendedAICombatStorage> CombatDataStorage { get; set;}

		[RED("attackCountLimit")] 		public CInt32 AttackCountLimit { get; set;}

		[RED("attackName")] 		public CName AttackName { get; set;}

		public CBTCondIsAttackCountGreaterThanLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondIsAttackCountGreaterThanLimit(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}