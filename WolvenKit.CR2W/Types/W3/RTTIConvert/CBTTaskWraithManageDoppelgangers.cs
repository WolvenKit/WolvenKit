using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithManageDoppelgangers : IBehTreeTask
	{
		[RED("killDoppelgangersAtDeath")] 		public CBool KillDoppelgangersAtDeath { get; set;}

		[RED("killDoppelgangersAfterTime")] 		public CFloat KillDoppelgangersAfterTime { get; set;}

		[RED("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[RED("healthPercentageToRegen")] 		public CFloat HealthPercentageToRegen { get; set;}

		[RED("m_spawnTime")] 		public CFloat M_spawnTime { get; set;}

		[RED("m_SplitEntities", 2,0)] 		public CArray<CHandle<CEntity>> M_SplitEntities { get; set;}

		[RED("m_MergeReceived")] 		public CInt32 M_MergeReceived { get; set;}

		[RED("m_HealthPercToReach")] 		public CFloat M_HealthPercToReach { get; set;}

		[RED("m_MergingStarted")] 		public CBool M_MergingStarted { get; set;}

		public CBTTaskWraithManageDoppelgangers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithManageDoppelgangers(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}