using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveTRGPlayerManualMovement : CMoveTRGScript
	{
		[Ordinal(1)] [RED("currVelocity")] 		public CFloat CurrVelocity { get; set;}

		[Ordinal(2)] [RED("m_heading")] 		public CFloat M_heading { get; set;}

		[Ordinal(3)] [RED("m_orientationWODump")] 		public CFloat M_orientationWODump { get; set;}

		[Ordinal(4)] [RED("m_headingChangeVal")] 		public CFloat M_headingChangeVal { get; set;}

		[Ordinal(5)] [RED("m_headingHistoryTime")] 		public CFloat M_headingHistoryTime { get; set;}

		[Ordinal(6)] [RED("m_headingHistory", 2,0)] 		public CArray<SHeadingHistory> M_headingHistory { get; set;}

		[Ordinal(7)] [RED("lastKnownPlayerHeading")] 		public CFloat LastKnownPlayerHeading { get; set;}

		public CMoveTRGPlayerManualMovement(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}