using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBoatDestructionVolume : CVariable
	{
		[Ordinal(0)] [RED("("areaHealth")] 		public CFloat AreaHealth { get; set;}

		[Ordinal(0)] [RED("("volumeCorners")] 		public Vector VolumeCorners { get; set;}

		[Ordinal(0)] [RED("("volumeLocalPosition")] 		public Vector VolumeLocalPosition { get; set;}

		public SBoatDestructionVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBoatDestructionVolume(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}