using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurCulling : CVariable
	{
		[RED("useViewfrustrumCulling")] 		public CBool UseViewfrustrumCulling { get; set;}

		[RED("useBackfaceCulling")] 		public CBool UseBackfaceCulling { get; set;}

		[RED("backfaceCullingThreshold")] 		public CFloat BackfaceCullingThreshold { get; set;}

		public SFurCulling(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurCulling(cr2w);

	}
}