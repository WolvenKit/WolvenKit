using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIInterruptOnHitOrOnCriticalEffect : IActionDecorator
	{
		[Ordinal(1)] [RED("completeOnHit")] 		public CBool CompleteOnHit { get; set;}

		[Ordinal(2)] [RED("completeOnCriticalEffect")] 		public CBool CompleteOnCriticalEffect { get; set;}

		public CAIInterruptOnHitOrOnCriticalEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIInterruptOnHitOrOnCriticalEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}