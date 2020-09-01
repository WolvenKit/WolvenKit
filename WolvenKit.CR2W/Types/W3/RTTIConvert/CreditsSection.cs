using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CreditsSection : CVariable
	{
		[Ordinal(0)] [RED("sectionName")] 		public CString SectionName { get; set;}

		[Ordinal(0)] [RED("positionNames", 2,0)] 		public CArray<CString> PositionNames { get; set;}

		[Ordinal(0)] [RED("crewNames", 2,0)] 		public CArray<CString> CrewNames { get; set;}

		[Ordinal(0)] [RED("displayTime")] 		public CFloat DisplayTime { get; set;}

		[Ordinal(0)] [RED("positionX")] 		public CInt32 PositionX { get; set;}

		[Ordinal(0)] [RED("positionY")] 		public CInt32 PositionY { get; set;}

		[Ordinal(0)] [RED("delay")] 		public CFloat Delay { get; set;}

		public CreditsSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CreditsSection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}