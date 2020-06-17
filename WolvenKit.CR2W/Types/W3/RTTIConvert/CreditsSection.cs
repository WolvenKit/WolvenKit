using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CreditsSection : CVariable
	{
		[RED("sectionName")] 		public CString SectionName { get; set;}

		[RED("positionNames", 2,0)] 		public CArray<CString> PositionNames { get; set;}

		[RED("crewNames", 2,0)] 		public CArray<CString> CrewNames { get; set;}

		[RED("displayTime")] 		public CFloat DisplayTime { get; set;}

		[RED("positionX")] 		public CInt32 PositionX { get; set;}

		[RED("positionY")] 		public CInt32 PositionY { get; set;}

		[RED("delay")] 		public CFloat Delay { get; set;}

		public CreditsSection(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CreditsSection(cr2w);

	}
}