using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AirDrainEntity : CGameplayEntity
	{
		[RED("customDrainPoints")] 		public CFloat CustomDrainPoints { get; set;}

		[RED("customDrainPercents")] 		public CFloat CustomDrainPercents { get; set;}

		[RED("factOnActivated")] 		public CString FactOnActivated { get; set;}

		[RED("factOnDeactivated")] 		public CString FactOnDeactivated { get; set;}

		public W3AirDrainEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AirDrainEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}