using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHorseCorrectionTrigger : CGameplayEntity
	{
		[Ordinal(0)] [RED("("valueOnEnter")] 		public CBool ValueOnEnter { get; set;}

		[Ordinal(0)] [RED("("valueOnExit")] 		public CBool ValueOnExit { get; set;}

		[Ordinal(0)] [RED("("horse")] 		public CHandle<CGameplayEntity> Horse { get; set;}

		[Ordinal(0)] [RED("("horseComp")] 		public CHandle<W3HorseComponent> HorseComp { get; set;}

		public CHorseCorrectionTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHorseCorrectionTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}