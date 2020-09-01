using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAttackRange : CObject
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("rangeMax")] 		public CFloat RangeMax { get; set;}

		[Ordinal(3)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(4)] [RED("angleOffset")] 		public CFloat AngleOffset { get; set;}

		[Ordinal(5)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(6)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(7)] [RED("lineOfSightHeight")] 		public CFloat LineOfSightHeight { get; set;}

		[Ordinal(8)] [RED("useHeadOrientation")] 		public CBool UseHeadOrientation { get; set;}

		public CAIAttackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAttackRange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}