using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Drowning : W3DamageOverTimeEffect
	{
		[Ordinal(1)] [RED("m_NoSaveLockInt")] 		public CInt32 M_NoSaveLockInt { get; set;}

		[Ordinal(2)] [RED("isEffectOn")] 		public CBool IsEffectOn { get; set;}

		[Ordinal(3)] [RED("mac")] 		public CHandle<CMovingPhysicalAgentComponent> Mac { get; set;}

		[Ordinal(4)] [RED("submergeDepth")] 		public CFloat SubmergeDepth { get; set;}

		public W3Effect_Drowning(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Drowning(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}