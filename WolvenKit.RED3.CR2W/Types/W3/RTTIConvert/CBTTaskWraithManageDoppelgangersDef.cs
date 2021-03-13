using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithManageDoppelgangersDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("killDoppelgangersAtDeath")] 		public CBool KillDoppelgangersAtDeath { get; set;}

		[Ordinal(2)] [RED("killDoppelgangersAfterTime")] 		public CFloat KillDoppelgangersAfterTime { get; set;}

		[Ordinal(3)] [RED("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[Ordinal(4)] [RED("healthPercentageToRegen")] 		public CFloat HealthPercentageToRegen { get; set;}

		public CBTTaskWraithManageDoppelgangersDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithManageDoppelgangersDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}