using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondMyHorseIsMountedDef : IBehTreeRiderConditionalTaskDefinition
	{
		[RED("waitForMountEnd")] 		public CBool WaitForMountEnd { get; set;}

		[RED("waitForDismountEnd")] 		public CBool WaitForDismountEnd { get; set;}

		[RED("returnTrueWhenNoHorse")] 		public CBool ReturnTrueWhenNoHorse { get; set;}

		public CBTCondMyHorseIsMountedDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondMyHorseIsMountedDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}