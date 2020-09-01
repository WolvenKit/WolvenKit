using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateMountHorse : CR4PlayerStateMountTheVehicle
	{
		[Ordinal(1)] [RED("horseComp")] 		public CHandle<W3HorseComponent> HorseComp { get; set;}

		[Ordinal(2)] [RED("mountAnimStarted")] 		public CBool MountAnimStarted { get; set;}

		[Ordinal(3)] [RED("MOUNT_TIMEOUT")] 		public CFloat MOUNT_TIMEOUT { get; set;}

		public CR4PlayerStateMountHorse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateMountHorse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}