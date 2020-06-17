using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNormalBlendComponent : CComponent
	{
		[RED("dataSource")] 		public CPtr<INormalBlendDataSource> DataSource { get; set;}

		[RED("useMainTick")] 		public CBool UseMainTick { get; set;}

		[RED("sourceMaterial")] 		public CHandle<IMaterial> SourceMaterial { get; set;}

		[RED("sourceNormalTexture")] 		public CHandle<ITexture> SourceNormalTexture { get; set;}

		[RED("normalBlendMaterial")] 		public CHandle<CMaterialInstance> NormalBlendMaterial { get; set;}

		[RED("normalBlendAreas", 2,0)] 		public CArray<Vector> NormalBlendAreas { get; set;}

		public CNormalBlendComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CNormalBlendComponent(cr2w);

	}
}