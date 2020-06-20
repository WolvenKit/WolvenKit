using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingHitFrontal : CExplorationInterceptorStateAbstract
	{
		[RED("behAnimEnd")] 		public CName BehAnimEnd { get; set;}

		[RED("timeMax")] 		public CFloat TimeMax { get; set;}

		[RED("dotCollToEnter")] 		public CFloat DotCollToEnter { get; set;}

		public CExplorationStateSkatingHitFrontal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingHitFrontal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}