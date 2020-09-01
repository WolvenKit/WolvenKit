using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIWalkToTargetWaitParams : IAIActionParameters
	{
		[Ordinal(0)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(0)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(0)] [RED("waitForTag")] 		public CName WaitForTag { get; set;}

		[Ordinal(0)] [RED("timeout")] 		public CFloat Timeout { get; set;}

		[Ordinal(0)] [RED("testDistance")] 		public CFloat TestDistance { get; set;}

		public CAIWalkToTargetWaitParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIWalkToTargetWaitParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}