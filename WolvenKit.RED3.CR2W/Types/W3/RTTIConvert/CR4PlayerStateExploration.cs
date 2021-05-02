using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateExploration : CR4PlayerStateExtendedMovable
	{
		[Ordinal(1)] [RED("wantsToSheatheWeapon")] 		public CBool WantsToSheatheWeapon { get; set;}

		[Ordinal(2)] [RED("m_lastUsedPCInput")] 		public CBool M_lastUsedPCInput { get; set;}

		[Ordinal(3)] [RED("cachedPos")] 		public Vector CachedPos { get; set;}

		[Ordinal(4)] [RED("constDamper")] 		public CHandle<ConstDamper> ConstDamper { get; set;}

		public CR4PlayerStateExploration(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}