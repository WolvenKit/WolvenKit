using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSlotComponent : CComponent
	{
		[RED("slots", 2,0)] 		public CArray<SSlotInfo> Slots { get; set;}

		[RED("sourceSkeleton")] 		public CSoft<CSkeleton> SourceSkeleton { get; set;}

		public CSlotComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSlotComponent(cr2w);

	}
}