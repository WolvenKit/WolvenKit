using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SIgniAspect : CVariable
	{
		[Ordinal(1)] [RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[Ordinal(2)] [RED("cone")] 		public CFloat Cone { get; set;}

		[Ordinal(3)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(4)] [RED("upgradedDistance")] 		public CFloat UpgradedDistance { get; set;}

		public SIgniAspect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SIgniAspect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}