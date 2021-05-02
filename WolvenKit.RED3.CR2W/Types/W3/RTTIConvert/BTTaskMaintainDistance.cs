using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskMaintainDistance : IBehTreeTask
	{
		[Ordinal(1)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("faceTarget")] 		public CBool FaceTarget { get; set;}

		[Ordinal(4)] [RED("fromOutsideDuration")] 		public CFloat FromOutsideDuration { get; set;}

		[Ordinal(5)] [RED("forceTarget")] 		public CName ForceTarget { get; set;}

		[Ordinal(6)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		public BTTaskMaintainDistance(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskMaintainDistance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}