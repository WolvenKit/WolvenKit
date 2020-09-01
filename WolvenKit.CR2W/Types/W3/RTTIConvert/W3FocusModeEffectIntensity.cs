using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FocusModeEffectIntensity : CObject
	{
		[Ordinal(0)] [RED("("chooseEntityStrategy")] 		public CEnum<EFocusModeChooseEntityStrategy> ChooseEntityStrategy { get; set;}

		[Ordinal(0)] [RED("("bestEntity")] 		public CHandle<CEntity> BestEntity { get; set;}

		[Ordinal(0)] [RED("("bestDistance")] 		public CFloat BestDistance { get; set;}

		[Ordinal(0)] [RED("("lastDistance")] 		public CFloat LastDistance { get; set;}

		[Ordinal(0)] [RED("("bestIntensity")] 		public CFloat BestIntensity { get; set;}

		[Ordinal(0)] [RED("("lastIntensity")] 		public CFloat LastIntensity { get; set;}

		public W3FocusModeEffectIntensity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FocusModeEffectIntensity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}