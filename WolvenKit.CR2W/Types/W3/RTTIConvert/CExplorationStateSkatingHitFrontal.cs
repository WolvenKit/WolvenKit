using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingHitFrontal : CExplorationInterceptorStateAbstract
	{
		[Ordinal(1)] [RED("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(2)] [RED("behAnimEnd")] 		public CName BehAnimEnd { get; set;}

		[Ordinal(3)] [RED("timeMax")] 		public CFloat TimeMax { get; set;}

		[Ordinal(4)] [RED("dotCollToEnter")] 		public CFloat DotCollToEnter { get; set;}

		public CExplorationStateSkatingHitFrontal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingHitFrontal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}