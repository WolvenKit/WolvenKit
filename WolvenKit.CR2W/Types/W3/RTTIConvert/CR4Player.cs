using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4Player : CPlayer
	{
		[RED("uselessProp")] 		public CEnum<EAsyncCheckResult> UselessProp { get; set;}

		[RED("horseWithInventory")] 		public EntityHandle HorseWithInventory { get; set;}

		[RED("delayBetweenIllusionOneliners")] 		public CFloat DelayBetweenIllusionOneliners { get; set;}

		public CR4Player(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Player(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}