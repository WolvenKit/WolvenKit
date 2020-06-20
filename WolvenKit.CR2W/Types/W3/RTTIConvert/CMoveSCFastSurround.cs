using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSCFastSurround : IMoveSteeringCondition
	{
		[RED("usageDelay")] 		public CFloat UsageDelay { get; set;}

		[RED("angleDistanceToActivate")] 		public CFloat AngleDistanceToActivate { get; set;}

		[RED("speedMinToActivate")] 		public CFloat SpeedMinToActivate { get; set;}

		[RED("angleDistanceToBreak")] 		public CFloat AngleDistanceToBreak { get; set;}

		[RED("speedMinLimitToBreak")] 		public CFloat SpeedMinLimitToBreak { get; set;}

		public CMoveSCFastSurround(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSCFastSurround(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}