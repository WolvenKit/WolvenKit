using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithDrainDance : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("drainDistance")] 		public CFloat DrainDistance { get; set;}

		[Ordinal(2)] [RED("drainTemplate")] 		public CHandle<CEntityTemplate> DrainTemplate { get; set;}

		[Ordinal(3)] [RED("m_isDraining")] 		public CBool M_isDraining { get; set;}

		[Ordinal(4)] [RED("m_DrainEffectEntity")] 		public CHandle<CEntity> M_DrainEffectEntity { get; set;}

		[Ordinal(5)] [RED("m_Disappeared")] 		public CBool M_Disappeared { get; set;}

		public CBTTaskWraithDrainDance(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}