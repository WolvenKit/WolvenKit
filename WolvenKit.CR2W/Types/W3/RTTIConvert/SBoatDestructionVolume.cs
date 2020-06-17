using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBoatDestructionVolume : CVariable
	{
		[RED("areaHealth")] 		public CFloat AreaHealth { get; set;}

		[RED("volumeCorners")] 		public Vector VolumeCorners { get; set;}

		[RED("volumeLocalPosition")] 		public Vector VolumeLocalPosition { get; set;}

		public SBoatDestructionVolume(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBoatDestructionVolume(cr2w);

	}
}