using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CUmbraScene : CResource
	{
		[RED("distanceMultiplier")] 		public CFloat DistanceMultiplier { get; set;}

		[RED("localUmbraOccThresholdMul")] 		public CHandle<CResourceSimplexTree> LocalUmbraOccThresholdMul { get; set;}

		public CUmbraScene(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CUmbraScene(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}