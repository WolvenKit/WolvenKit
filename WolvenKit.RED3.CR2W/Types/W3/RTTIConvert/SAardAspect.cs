using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAardAspect : CVariable
	{
		[Ordinal(1)] [RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[Ordinal(2)] [RED("cone")] 		public CFloat Cone { get; set;}

		[Ordinal(3)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(4)] [RED("distanceUpgrade1")] 		public CFloat DistanceUpgrade1 { get; set;}

		[Ordinal(5)] [RED("distanceUpgrade2")] 		public CFloat DistanceUpgrade2 { get; set;}

		[Ordinal(6)] [RED("distanceUpgrade3")] 		public CFloat DistanceUpgrade3 { get; set;}

		public SAardAspect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}