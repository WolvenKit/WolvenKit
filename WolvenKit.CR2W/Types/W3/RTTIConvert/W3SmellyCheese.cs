using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SmellyCheese : W3AirDrainEntity
	{
		[RED("deactivatedByAard")] 		public CBool DeactivatedByAard { get; set;}

		[RED("smellEffectName")] 		public CName SmellEffectName { get; set;}

		[RED("aardedEffectName")] 		public CName AardedEffectName { get; set;}

		[RED("reactivateTimer")] 		public CFloat ReactivateTimer { get; set;}

		public W3SmellyCheese(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SmellyCheese(cr2w);

	}
}