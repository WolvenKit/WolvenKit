using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AirDrainEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("customDrainPoints")] 		public CFloat CustomDrainPoints { get; set;}

		[Ordinal(2)] [RED("customDrainPercents")] 		public CFloat CustomDrainPercents { get; set;}

		[Ordinal(3)] [RED("factOnActivated")] 		public CString FactOnActivated { get; set;}

		[Ordinal(4)] [RED("factOnDeactivated")] 		public CString FactOnDeactivated { get; set;}

		public W3AirDrainEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}