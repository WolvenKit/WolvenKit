using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyingCrittersLairEntityScript : CFlyingCrittersLairEntity
	{
		[RED("dynamicGroups")] 		public CBool DynamicGroups { get; set;}

		[RED("doCircling")] 		public CBool DoCircling { get; set;}

		[RED("isAgressive")] 		public CBool IsAgressive { get; set;}

		[RED("initDynamicGroups")] 		public CBool InitDynamicGroups { get; set;}

		[RED("initDoCircling")] 		public CBool InitDoCircling { get; set;}

		[RED("initAgressive")] 		public CBool InitAgressive { get; set;}

		[RED("initMain")] 		public CBool InitMain { get; set;}

		[RED("isActive")] 		public CBool IsActive { get; set;}

		[RED("firstActivation")] 		public CBool FirstActivation { get; set;}

		[RED("idleGroupIndexArray", 2,0)] 		public CArray<CInt32> IdleGroupIndexArray { get; set;}

		[RED("m_requestGroupStateArray", 2,0)] 		public CArray<CName> M_requestGroupStateArray { get; set;}

		[RED("m_requestGroupIdStateArray", 2,0)] 		public CArray<CHandle<W3FlyingSwarmStateChangeRequest>> M_requestGroupIdStateArray { get; set;}

		[RED("m_requestCreateGroupArray", 2,0)] 		public CArray<CHandle<W3FlyingSwarmCreateGroupRequest>> M_requestCreateGroupArray { get; set;}

		[RED("m_allGroupsStateRequest")] 		public CName M_allGroupsStateRequest { get; set;}

		[RED("m_requestAllGroupsDespawn")] 		public CBool M_requestAllGroupsDespawn { get; set;}

		[RED("m_requestAllGroupChangeState")] 		public CBool M_requestAllGroupChangeState { get; set;}

		[RED("m_birdMaster")] 		public CHandle<CGameplayEntity> M_birdMaster { get; set;}

		[RED("m_gotoRequestArray", 2,0)] 		public CArray<CHandle<GotoRequest>> M_gotoRequestArray { get; set;}

		[RED("m_requestCircle")] 		public CBool M_requestCircle { get; set;}

		[RED("m_requestSupernatural")] 		public CBool M_requestSupernatural { get; set;}

		[RED("m_requestAttack")] 		public CBool M_requestAttack { get; set;}

		[RED("m_requestDespawnTest")] 		public CBool M_requestDespawnTest { get; set;}

		[RED("m_requestGroupMerge")] 		public CBool M_requestGroupMerge { get; set;}

		[RED("m_requestGroupSplit")] 		public CBool M_requestGroupSplit { get; set;}

		[RED("m_requestPopulateGroup")] 		public CBool M_requestPopulateGroup { get; set;}

		public CFlyingCrittersLairEntityScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyingCrittersLairEntityScript(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}