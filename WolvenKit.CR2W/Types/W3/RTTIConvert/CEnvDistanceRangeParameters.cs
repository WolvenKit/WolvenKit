using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDistanceRangeParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("distance")] 		public SSimpleCurve Distance { get; set;}

		[RED("range")] 		public SSimpleCurve Range { get; set;}

		public CEnvDistanceRangeParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvDistanceRangeParameters(cr2w);

	}
}