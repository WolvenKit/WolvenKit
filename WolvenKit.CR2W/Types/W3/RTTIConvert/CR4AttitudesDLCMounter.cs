using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4AttitudesDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(0)] [RED("attitudeGroupsTableFilePath")] 		public CString AttitudeGroupsTableFilePath { get; set;}

		[Ordinal(0)] [RED("attitudesXMLFilePath")] 		public CString AttitudesXMLFilePath { get; set;}

		public CR4AttitudesDLCMounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4AttitudesDLCMounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}