using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SummonedFlies : CGameplayEntity
	{
		[RED("fleeDuration")] 		public CFloat FleeDuration { get; set;}

		[RED("lookForTarget")] 		public CBool LookForTarget { get; set;}

		[RED("detectionDistance")] 		public CFloat DetectionDistance { get; set;}

		[RED("pursueDistance")] 		public CFloat PursueDistance { get; set;}

		[RED("ignoreTag")] 		public CName IgnoreTag { get; set;}

		[RED("m_Target")] 		public CHandle<CNode> M_Target { get; set;}

		[RED("m_StartPos")] 		public Vector M_StartPos { get; set;}

		[RED("m_SummonedCmp")] 		public CHandle<W3SummonedEntityComponent> M_SummonedCmp { get; set;}

		[RED("m_SlideCmp")] 		public CHandle<W3SlideToTargetComponent> M_SlideCmp { get; set;}

		public W3SummonedFlies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SummonedFlies(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}