using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemFlare : CFXTrackItem
	{
		[Ordinal(1)] [RED("material")] 		public CHandle<CMaterialInstance> Material { get; set;}

		[Ordinal(2)] [RED("parameters")] 		public SFlareParameters Parameters { get; set;}

		[Ordinal(3)] [RED("spawner")] 		public CPtr<IFXSpawner> Spawner { get; set;}

		public CFXTrackItemFlare(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}