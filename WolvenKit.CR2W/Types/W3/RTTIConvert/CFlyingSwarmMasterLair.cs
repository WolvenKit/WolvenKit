using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyingSwarmMasterLair : CFlyingCrittersLairEntityScript
	{
		[RED("m_spawnFromBirdMasterRequest")] 		public CInt32 M_spawnFromBirdMasterRequest { get; set;}

		[RED("m_spawnFromShieldGroupRequest")] 		public CInt32 M_spawnFromShieldGroupRequest { get; set;}

		[RED("m_despawnFromBirdMasterRequest")] 		public CInt32 M_despawnFromBirdMasterRequest { get; set;}

		[RED("teleportGroupId")] 		public CFlyingGroupId TeleportGroupId { get; set;}

		[RED("shieldGroupId")] 		public CFlyingGroupId ShieldGroupId { get; set;}

		[RED("passedInput")] 		public CHandle<CFlyingSwarmScriptInput> PassedInput { get; set;}

		[RED("m_init")] 		public CBool M_init { get; set;}

		[RED("disperseShield")] 		public CBool DisperseShield { get; set;}

		[RED("teleportGroupPosition")] 		public Vector TeleportGroupPosition { get; set;}

		[RED("shieldBirdCount")] 		public CInt32 ShieldBirdCount { get; set;}

		[RED("teleportBirdCount")] 		public CInt32 TeleportBirdCount { get; set;}

		[RED("spawnCount")] 		public CInt32 SpawnCount { get; set;}

		[RED("checkBeginAttackArray", 2,0)] 		public CArray<CFlyingGroupId> CheckBeginAttackArray { get; set;}

		[RED("shieldBirdState")] 		public CName ShieldBirdState { get; set;}

		public CFlyingSwarmMasterLair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyingSwarmMasterLair(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}