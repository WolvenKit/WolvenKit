using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskVolumetricMove : IBehTreeTask
	{
		[Ordinal(1)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(2)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(3)] [RED("target")] 		public CHandle<CNode> Target { get; set;}

		[Ordinal(4)] [RED("dest")] 		public Vector Dest { get; set;}

		[Ordinal(5)] [RED("npcPos")] 		public Vector NpcPos { get; set;}

		[Ordinal(6)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		[Ordinal(7)] [RED("targetToNpcVec")] 		public Vector TargetToNpcVec { get; set;}

		[Ordinal(8)] [RED("npcToTargetVec")] 		public Vector NpcToTargetVec { get; set;}

		[Ordinal(9)] [RED("path", 2,0)] 		public CArray<Vector> Path { get; set;}

		[Ordinal(10)] [RED("m_collisionGroupsNames", 2,0)] 		public CArray<CName> M_collisionGroupsNames { get; set;}

		[Ordinal(11)] [RED("m_resetSweep")] 		public CBool M_resetSweep { get; set;}

		[Ordinal(12)] [RED("m_sweepId")] 		public SScriptSweepId M_sweepId { get; set;}

		[Ordinal(13)] [RED("m_traceManager")] 		public CHandle<CScriptBatchQueryAccessor> M_traceManager { get; set;}

		[Ordinal(14)] [RED("m_lastSweepResult")] 		public CBool M_lastSweepResult { get; set;}

		public CBTTaskVolumetricMove(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskVolumetricMove(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}