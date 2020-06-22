using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScriptSoundSystem : CObject
	{
		[RED("currentGameState")] 		public CEnum<ESoundGameState> CurrentGameState { get; set;}

		[RED("defaultGameState")] 		public CEnum<ESoundGameState> DefaultGameState { get; set;}

		[RED("defaultStates", 2,0)] 		public CArray<CEnum<ESoundGameState>> DefaultStates { get; set;}

		[RED("stateChangeTimestamp")] 		public CFloat StateChangeTimestamp { get; set;}

		[RED("stateCheckCooldown")] 		public CFloat StateCheckCooldown { get; set;}

		[RED("isGameStopped")] 		public CBool IsGameStopped { get; set;}

		[RED("currentThreatRating")] 		public CFloat CurrentThreatRating { get; set;}

		[RED("desiredThreatRating")] 		public CFloat DesiredThreatRating { get; set;}

		[RED("lastThreatUpdateTime")] 		public CFloat LastThreatUpdateTime { get; set;}

		[RED("lastThreatDampTime")] 		public CFloat LastThreatDampTime { get; set;}

		[RED("threatUpdateCooldown")] 		public CFloat ThreatUpdateCooldown { get; set;}

		[RED("threatDampCooldown")] 		public CFloat ThreatDampCooldown { get; set;}

		[RED("threatDamper")] 		public CHandle<SpringDamper> ThreatDamper { get; set;}

		[RED("monsterHunt")] 		public CBool MonsterHunt { get; set;}

		[RED("monster")] 		public CBool Monster { get; set;}

		[RED("isBlackscreen")] 		public CBool IsBlackscreen { get; set;}

		[RED("soundSystemSettings")] 		public CHandle<C2dArray> SoundSystemSettings { get; set;}

		[RED("threatWeight")] 		public CInt32 ThreatWeight { get; set;}

		[RED("levelWeight")] 		public CInt32 LevelWeight { get; set;}

		[RED("tweakWeight")] 		public CFloat TweakWeight { get; set;}

		public CScriptSoundSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CScriptSoundSystem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}