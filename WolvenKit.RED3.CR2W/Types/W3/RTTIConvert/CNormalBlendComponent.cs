using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNormalBlendComponent : CComponent
	{
		[Ordinal(1)] [RED("dataSource")] 		public CPtr<INormalBlendDataSource> DataSource { get; set;}

		[Ordinal(2)] [RED("useMainTick")] 		public CBool UseMainTick { get; set;}

		[Ordinal(3)] [RED("sourceMaterial")] 		public CHandle<IMaterial> SourceMaterial { get; set;}

		[Ordinal(4)] [RED("sourceNormalTexture")] 		public CHandle<ITexture> SourceNormalTexture { get; set;}

		[Ordinal(5)] [RED("normalBlendMaterial")] 		public CHandle<CMaterialInstance> NormalBlendMaterial { get; set;}

		[Ordinal(6)] [RED("normalBlendAreas", 2,0)] 		public CArray<Vector> NormalBlendAreas { get; set;}

		public CNormalBlendComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNormalBlendComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}