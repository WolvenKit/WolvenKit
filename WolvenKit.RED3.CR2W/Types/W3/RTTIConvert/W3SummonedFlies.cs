using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SummonedFlies : CGameplayEntity
	{
		[Ordinal(1)] [RED("fleeDuration")] 		public CFloat FleeDuration { get; set;}

		[Ordinal(2)] [RED("lookForTarget")] 		public CBool LookForTarget { get; set;}

		[Ordinal(3)] [RED("detectionDistance")] 		public CFloat DetectionDistance { get; set;}

		[Ordinal(4)] [RED("pursueDistance")] 		public CFloat PursueDistance { get; set;}

		[Ordinal(5)] [RED("ignoreTag")] 		public CName IgnoreTag { get; set;}

		[Ordinal(6)] [RED("m_Target")] 		public CHandle<CNode> M_Target { get; set;}

		[Ordinal(7)] [RED("m_StartPos")] 		public Vector M_StartPos { get; set;}

		[Ordinal(8)] [RED("m_SummonedCmp")] 		public CHandle<W3SummonedEntityComponent> M_SummonedCmp { get; set;}

		[Ordinal(9)] [RED("m_SlideCmp")] 		public CHandle<W3SlideToTargetComponent> M_SlideCmp { get; set;}

		public W3SummonedFlies(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SummonedFlies(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}