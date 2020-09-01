using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NightWraithIris : CNewNPC
	{
		[Ordinal(0)] [RED("("m_CurrentHealthSection")] 		public CInt32 M_CurrentHealthSection { get; set;}

		[Ordinal(0)] [RED("("m_ClosestPainting")] 		public CHandle<CNode> M_ClosestPainting { get; set;}

		[Ordinal(0)] [RED("("m_TargetPainting")] 		public CHandle<W3IrisPainting> M_TargetPainting { get; set;}

		[Ordinal(0)] [RED("("m_Paintings", 2,0)] 		public CArray<CHandle<CNode>> M_Paintings { get; set;}

		[Ordinal(0)] [RED("("m_WaitingForSpawnEnd")] 		public CBool M_WaitingForSpawnEnd { get; set;}

		public W3NightWraithIris(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NightWraithIris(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}