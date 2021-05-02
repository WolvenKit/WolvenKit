using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskIrisRequestPortal : IBehTreeTask
	{
		[Ordinal(1)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(2)] [RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(3)] [RED("m_Npc")] 		public CHandle<W3NightWraithIris> M_Npc { get; set;}

		public BTTaskIrisRequestPortal(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskIrisRequestPortal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}