using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AirDrainArea : CGameplayEntity
	{
		[Ordinal(1)] [RED("customDrainPoints")] 		public CFloat CustomDrainPoints { get; set;}

		[Ordinal(2)] [RED("customDrainPercents")] 		public CFloat CustomDrainPercents { get; set;}

		public W3AirDrainArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AirDrainArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}