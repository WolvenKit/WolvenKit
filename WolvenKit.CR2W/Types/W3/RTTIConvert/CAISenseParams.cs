using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISenseParams : CObject
	{
		[Ordinal(1)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("("rangeMin")] 		public CFloat RangeMin { get; set;}

		[Ordinal(3)] [RED("("rangeMax")] 		public CFloat RangeMax { get; set;}

		[Ordinal(4)] [RED("("rangeAngle")] 		public CFloat RangeAngle { get; set;}

		[Ordinal(5)] [RED("("height")] 		public CFloat Height { get; set;}

		[Ordinal(6)] [RED("("testLOS")] 		public CBool TestLOS { get; set;}

		[Ordinal(7)] [RED("("detectOnlyHostiles")] 		public CBool DetectOnlyHostiles { get; set;}

		public CAISenseParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAISenseParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}