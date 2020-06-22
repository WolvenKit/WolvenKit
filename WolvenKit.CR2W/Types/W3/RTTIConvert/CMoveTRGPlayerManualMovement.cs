using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveTRGPlayerManualMovement : CMoveTRGScript
	{
		[RED("currVelocity")] 		public CFloat CurrVelocity { get; set;}

		[RED("m_heading")] 		public CFloat M_heading { get; set;}

		[RED("m_orientationWODump")] 		public CFloat M_orientationWODump { get; set;}

		[RED("m_headingChangeVal")] 		public CFloat M_headingChangeVal { get; set;}

		[RED("m_headingHistoryTime")] 		public CFloat M_headingHistoryTime { get; set;}

		[RED("m_headingHistory", 2,0)] 		public CArray<SHeadingHistory> M_headingHistory { get; set;}

		[RED("lastKnownPlayerHeading")] 		public CFloat LastKnownPlayerHeading { get; set;}

		public CMoveTRGPlayerManualMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveTRGPlayerManualMovement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}