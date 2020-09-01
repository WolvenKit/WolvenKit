using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskCaretakerManager : IBehTreeTask
	{
		[Ordinal(0)] [RED("drainTemplate")] 		public CHandle<CEntityTemplate> DrainTemplate { get; set;}

		[Ordinal(0)] [RED("recoverPercPerHit")] 		public CFloat RecoverPercPerHit { get; set;}

		[Ordinal(0)] [RED("shadesModifier")] 		public CFloat ShadesModifier { get; set;}

		[Ordinal(0)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[Ordinal(0)] [RED("m_HealthObjective")] 		public CFloat M_HealthObjective { get; set;}

		[Ordinal(0)] [RED("m_DrainEffectEntity")] 		public CHandle<CEntity> M_DrainEffectEntity { get; set;}

		[Ordinal(0)] [RED("m_SummonerComponent")] 		public CHandle<W3SummonerComponent> M_SummonerComponent { get; set;}

		[Ordinal(0)] [RED("m_RefreshTargetDelay")] 		public CFloat M_RefreshTargetDelay { get; set;}

		public BTTaskCaretakerManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskCaretakerManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}