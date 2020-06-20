using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SApplicatorSpawnEffect : CVariable
	{
		[RED("spawnAbilityName")] 		public CName SpawnAbilityName { get; set;}

		[RED("spawnType")] 		public CEnum<EEffectType> SpawnType { get; set;}

		[RED("spawnFlagsHostile")] 		public CBool SpawnFlagsHostile { get; set;}

		[RED("spawnFlagsNeutral")] 		public CBool SpawnFlagsNeutral { get; set;}

		[RED("spawnFlagsFriendly")] 		public CBool SpawnFlagsFriendly { get; set;}

		[RED("spawnSourceName")] 		public CString SpawnSourceName { get; set;}

		public SApplicatorSpawnEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SApplicatorSpawnEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}