using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyingCrittersLairEntityScript : CFlyingCrittersLairEntity
	{
		[Ordinal(1)] [RED("dynamicGroups")] 		public CBool DynamicGroups { get; set;}

		[Ordinal(2)] [RED("doCircling")] 		public CBool DoCircling { get; set;}

		[Ordinal(3)] [RED("isAgressive")] 		public CBool IsAgressive { get; set;}

		[Ordinal(4)] [RED("initDynamicGroups")] 		public CBool InitDynamicGroups { get; set;}

		[Ordinal(5)] [RED("initDoCircling")] 		public CBool InitDoCircling { get; set;}

		[Ordinal(6)] [RED("initAgressive")] 		public CBool InitAgressive { get; set;}

		[Ordinal(7)] [RED("initMain")] 		public CBool InitMain { get; set;}

		[Ordinal(8)] [RED("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(9)] [RED("firstActivation")] 		public CBool FirstActivation { get; set;}

		[Ordinal(10)] [RED("idleGroupIndexArray", 2,0)] 		public CArray<CInt32> IdleGroupIndexArray { get; set;}

		[Ordinal(11)] [RED("m_requestGroupStateArray", 2,0)] 		public CArray<CName> M_requestGroupStateArray { get; set;}

		[Ordinal(12)] [RED("m_requestGroupIdStateArray", 2,0)] 		public CArray<CHandle<W3FlyingSwarmStateChangeRequest>> M_requestGroupIdStateArray { get; set;}

		[Ordinal(13)] [RED("m_requestCreateGroupArray", 2,0)] 		public CArray<CHandle<W3FlyingSwarmCreateGroupRequest>> M_requestCreateGroupArray { get; set;}

		[Ordinal(14)] [RED("m_allGroupsStateRequest")] 		public CName M_allGroupsStateRequest { get; set;}

		[Ordinal(15)] [RED("m_requestAllGroupsDespawn")] 		public CBool M_requestAllGroupsDespawn { get; set;}

		[Ordinal(16)] [RED("m_requestAllGroupChangeState")] 		public CBool M_requestAllGroupChangeState { get; set;}

		[Ordinal(17)] [RED("m_birdMaster")] 		public CHandle<CGameplayEntity> M_birdMaster { get; set;}

		[Ordinal(18)] [RED("m_gotoRequestArray", 2,0)] 		public CArray<CHandle<GotoRequest>> M_gotoRequestArray { get; set;}

		[Ordinal(19)] [RED("m_requestCircle")] 		public CBool M_requestCircle { get; set;}

		[Ordinal(20)] [RED("m_requestSupernatural")] 		public CBool M_requestSupernatural { get; set;}

		[Ordinal(21)] [RED("m_requestAttack")] 		public CBool M_requestAttack { get; set;}

		[Ordinal(22)] [RED("m_requestDespawnTest")] 		public CBool M_requestDespawnTest { get; set;}

		[Ordinal(23)] [RED("m_requestGroupMerge")] 		public CBool M_requestGroupMerge { get; set;}

		[Ordinal(24)] [RED("m_requestGroupSplit")] 		public CBool M_requestGroupSplit { get; set;}

		[Ordinal(25)] [RED("m_requestPopulateGroup")] 		public CBool M_requestPopulateGroup { get; set;}

		public CFlyingCrittersLairEntityScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyingCrittersLairEntityScript(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}