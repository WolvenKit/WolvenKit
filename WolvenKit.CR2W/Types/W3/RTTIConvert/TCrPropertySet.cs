using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TCrPropertySet : CObject
	{
		[Ordinal(0)] [RED("("shoulderWeight")] 		public CFloat ShoulderWeight { get; set;}

		[Ordinal(0)] [RED("("shoulderLimitUpDeg")] 		public CFloat ShoulderLimitUpDeg { get; set;}

		[Ordinal(0)] [RED("("shoulderLimitDownDeg")] 		public CFloat ShoulderLimitDownDeg { get; set;}

		[Ordinal(0)] [RED("("shoulderLimitLeftDeg")] 		public CFloat ShoulderLimitLeftDeg { get; set;}

		[Ordinal(0)] [RED("("shoulderLimitRightDeg")] 		public CFloat ShoulderLimitRightDeg { get; set;}

		public TCrPropertySet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TCrPropertySet(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}