using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_BleedingTracking : W3DamageOverTimeEffect
	{
		[Ordinal(1)] [RED("bloodTemplate")] 		public CHandle<CEntityTemplate> BloodTemplate { get; set;}

		[Ordinal(2)] [RED("bloodSpawnTimer")] 		public CFloat BloodSpawnTimer { get; set;}

		[Ordinal(3)] [RED("BLOOD_SPAWN_DELAY_MIN")] 		public CInt32 BLOOD_SPAWN_DELAY_MIN { get; set;}

		[Ordinal(4)] [RED("BLOOD_SPAWN_DELAY_MAX")] 		public CInt32 BLOOD_SPAWN_DELAY_MAX { get; set;}

		public W3Effect_BleedingTracking(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_BleedingTracking(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}