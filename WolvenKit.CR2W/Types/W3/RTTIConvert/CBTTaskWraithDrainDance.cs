using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithDrainDance : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(0)] [RED("("drainDistance")] 		public CFloat DrainDistance { get; set;}

		[Ordinal(0)] [RED("("drainTemplate")] 		public CHandle<CEntityTemplate> DrainTemplate { get; set;}

		[Ordinal(0)] [RED("("m_isDraining")] 		public CBool M_isDraining { get; set;}

		[Ordinal(0)] [RED("("m_DrainEffectEntity")] 		public CHandle<CEntity> M_DrainEffectEntity { get; set;}

		[Ordinal(0)] [RED("("m_Disappeared")] 		public CBool M_Disappeared { get; set;}

		public CBTTaskWraithDrainDance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithDrainDance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}