using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SmellyCheese : W3AirDrainEntity
	{
		[Ordinal(1)] [RED("deactivatedByAard")] 		public CBool DeactivatedByAard { get; set;}

		[Ordinal(2)] [RED("smellEffectName")] 		public CName SmellEffectName { get; set;}

		[Ordinal(3)] [RED("aardedEffectName")] 		public CName AardedEffectName { get; set;}

		[Ordinal(4)] [RED("reactivateTimer")] 		public CFloat ReactivateTimer { get; set;}

		[Ordinal(5)] [RED("deactivated")] 		public CBool Deactivated { get; set;}

		public W3SmellyCheese(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SmellyCheese(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}