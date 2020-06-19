using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAardAspect : CVariable
	{
		[RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[RED("cone")] 		public CFloat Cone { get; set;}

		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("distanceUpgrade1")] 		public CFloat DistanceUpgrade1 { get; set;}

		[RED("distanceUpgrade2")] 		public CFloat DistanceUpgrade2 { get; set;}

		[RED("distanceUpgrade3")] 		public CFloat DistanceUpgrade3 { get; set;}

		public SAardAspect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAardAspect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}