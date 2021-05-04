using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Frozen : W3ImmobilizeEffect
	{
		[Ordinal(1)] [RED("killOnHit")] 		public CBool KillOnHit { get; set;}

		[Ordinal(2)] [RED("bonusDamagePercents")] 		public CFloat BonusDamagePercents { get; set;}

		[Ordinal(3)] [RED("targetWasFlying")] 		public CBool TargetWasFlying { get; set;}

		[Ordinal(4)] [RED("pushPriority")] 		public CEnum<EInteractionPriority> PushPriority { get; set;}

		[Ordinal(5)] [RED("wasKnockedDown")] 		public CBool WasKnockedDown { get; set;}

		public W3Effect_Frozen(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}