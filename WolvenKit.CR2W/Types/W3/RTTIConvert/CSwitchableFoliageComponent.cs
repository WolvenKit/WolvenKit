using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSwitchableFoliageComponent : CComponent
	{
		[RED("resource")] 		public CHandle<CSwitchableFoliageResource> Resource { get; set;}

		[RED("minimumStreamingDistance")] 		public CUInt32 MinimumStreamingDistance { get; set;}

		public CSwitchableFoliageComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSwitchableFoliageComponent(cr2w);

	}
}