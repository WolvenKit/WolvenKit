using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLightFlickering : CVariable
	{
		[Ordinal(1)] [RED("("positionOffset")] 		public CFloat PositionOffset { get; set;}

		[Ordinal(2)] [RED("("flickerStrength")] 		public CFloat FlickerStrength { get; set;}

		[Ordinal(3)] [RED("("flickerPeriod")] 		public CFloat FlickerPeriod { get; set;}

		public SLightFlickering(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLightFlickering(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}