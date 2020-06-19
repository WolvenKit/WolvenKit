using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAttackRange : CObject
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("rangeMax")] 		public CFloat RangeMax { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("angleOffset")] 		public CFloat AngleOffset { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[RED("lineOfSightHeight")] 		public CFloat LineOfSightHeight { get; set;}

		[RED("useHeadOrientation")] 		public CBool UseHeadOrientation { get; set;}

		public CAIAttackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAttackRange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}