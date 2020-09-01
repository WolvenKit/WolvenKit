using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MedallionFX : CEntity
	{
		[Ordinal(0)] [RED("("scaleVector")] 		public Vector ScaleVector { get; set;}

		[Ordinal(0)] [RED("("medallionScaleRate")] 		public CFloat MedallionScaleRate { get; set;}

		[Ordinal(0)] [RED("("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(0)] [RED("("medallionComponent")] 		public CHandle<CComponent> MedallionComponent { get; set;}

		public W3MedallionFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MedallionFX(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}