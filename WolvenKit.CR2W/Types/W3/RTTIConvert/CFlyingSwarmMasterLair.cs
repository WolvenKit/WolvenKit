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
		[Ordinal(0)] [RED("("m_spawnFromBirdMasterRequest")] 		public CInt32 M_spawnFromBirdMasterRequest { get; set;}

		[Ordinal(0)] [RED("("m_spawnFromShieldGroupRequest")] 		public CInt32 M_spawnFromShieldGroupRequest { get; set;}

		[Ordinal(0)] [RED("("m_despawnFromBirdMasterRequest")] 		public CInt32 M_despawnFromBirdMasterRequest { get; set;}

		[Ordinal(0)] [RED("("teleportGroupId")] 		public CFlyingGroupId TeleportGroupId { get; set;}

		[Ordinal(0)] [RED("("shieldGroupId")] 		public CFlyingGroupId ShieldGroupId { get; set;}

		[Ordinal(0)] [RED("("passedInput")] 		public CHandle<CFlyingSwarmScriptInput> PassedInput { get; set;}

		[Ordinal(0)] [RED("("m_init")] 		public CBool M_init { get; set;}

		[Ordinal(0)] [RED("("disperseShield")] 		public CBool DisperseShield { get; set;}

		[Ordinal(0)] [RED("("teleportGroupPosition")] 		public Vector TeleportGroupPosition { get; set;}

		[Ordinal(0)] [RED("("shieldBirdCount")] 		public CInt32 ShieldBirdCount { get; set;}

		[Ordinal(0)] [RED("("teleportBirdCount")] 		public CInt32 TeleportBirdCount { get; set;}

		[Ordinal(0)] [RED("("spawnCount")] 		public CInt32 SpawnCount { get; set;}

		[Ordinal(0)] [RED("("checkBeginAttackArray", 2,0)] 		public CArray<CFlyingGroupId> CheckBeginAttackArray { get; set;}

		[Ordinal(0)] [RED("("shieldBirdState")] 		public CName ShieldBirdState { get; set;}

		public CFlyingSwarmMasterLair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyingSwarmMasterLair(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}