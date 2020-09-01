using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithManageDoppelgangers : IBehTreeTask
	{
		[Ordinal(1)] [RED("killDoppelgangersAtDeath")] 		public CBool KillDoppelgangersAtDeath { get; set;}

		[Ordinal(2)] [RED("killDoppelgangersAfterTime")] 		public CFloat KillDoppelgangersAfterTime { get; set;}

		[Ordinal(3)] [RED("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[Ordinal(4)] [RED("healthPercentageToRegen")] 		public CFloat HealthPercentageToRegen { get; set;}

		[Ordinal(5)] [RED("m_spawnTime")] 		public CFloat M_spawnTime { get; set;}

		[Ordinal(6)] [RED("m_SplitEntities", 2,0)] 		public CArray<CHandle<CEntity>> M_SplitEntities { get; set;}

		[Ordinal(7)] [RED("m_MergeReceived")] 		public CInt32 M_MergeReceived { get; set;}

		[Ordinal(8)] [RED("m_HealthPercToReach")] 		public CFloat M_HealthPercToReach { get; set;}

		[Ordinal(9)] [RED("m_MergingStarted")] 		public CBool M_MergingStarted { get; set;}

		public CBTTaskWraithManageDoppelgangers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithManageDoppelgangers(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}