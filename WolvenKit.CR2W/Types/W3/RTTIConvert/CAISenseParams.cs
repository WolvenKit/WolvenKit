using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISenseParams : CObject
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("rangeMin")] 		public CFloat RangeMin { get; set;}

		[RED("rangeMax")] 		public CFloat RangeMax { get; set;}

		[RED("rangeAngle")] 		public CFloat RangeAngle { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("testLOS")] 		public CBool TestLOS { get; set;}

		[RED("detectOnlyHostiles")] 		public CBool DetectOnlyHostiles { get; set;}

		public CAISenseParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAISenseParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}