using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CFoliageResource : CResource
	{
		[RED("bbox")] 		public Box Bbox { get; set;}

		[RED("gridbbox")] 		public Box Gridbbox { get; set;}

		[RED("version")] 		public CUInt32 Version { get; set;}

		public CFoliageResource(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CFoliageResource(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}