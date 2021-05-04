using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTKeepAwayTarget : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[Ordinal(2)] [RED("speed")] 		public CFloat Speed { get; set;}

		public CMoveSTKeepAwayTarget(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}