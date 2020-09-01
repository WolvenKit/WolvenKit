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
		[Ordinal(0)] [RED("("currentGameState")] 		public CEnum<ESoundGameState> CurrentGameState { get; set;}

		[Ordinal(0)] [RED("("defaultGameState")] 		public CEnum<ESoundGameState> DefaultGameState { get; set;}

		[Ordinal(0)] [RED("("defaultStates", 2,0)] 		public CArray<CEnum<ESoundGameState>> DefaultStates { get; set;}

		[Ordinal(0)] [RED("("stateChangeTimestamp")] 		public CFloat StateChangeTimestamp { get; set;}

		[Ordinal(0)] [RED("("stateCheckCooldown")] 		public CFloat StateCheckCooldown { get; set;}

		[Ordinal(0)] [RED("("isGameStopped")] 		public CBool IsGameStopped { get; set;}

		[Ordinal(0)] [RED("("currentThreatRating")] 		public CFloat CurrentThreatRating { get; set;}

		[Ordinal(0)] [RED("("desiredThreatRating")] 		public CFloat DesiredThreatRating { get; set;}

		[Ordinal(0)] [RED("("lastThreatUpdateTime")] 		public CFloat LastThreatUpdateTime { get; set;}

		[Ordinal(0)] [RED("("lastThreatDampTime")] 		public CFloat LastThreatDampTime { get; set;}

		[Ordinal(0)] [RED("("threatUpdateCooldown")] 		public CFloat ThreatUpdateCooldown { get; set;}

		[Ordinal(0)] [RED("("threatDampCooldown")] 		public CFloat ThreatDampCooldown { get; set;}

		[Ordinal(0)] [RED("("threatDamper")] 		public CHandle<SpringDamper> ThreatDamper { get; set;}

		[Ordinal(0)] [RED("("monsterHunt")] 		public CBool MonsterHunt { get; set;}

		[Ordinal(0)] [RED("("monster")] 		public CBool Monster { get; set;}

		[Ordinal(0)] [RED("("isBlackscreen")] 		public CBool IsBlackscreen { get; set;}

		[Ordinal(0)] [RED("("soundSystemSettings")] 		public CHandle<C2dArray> SoundSystemSettings { get; set;}

		[Ordinal(0)] [RED("("threatWeight")] 		public CInt32 ThreatWeight { get; set;}

		[Ordinal(0)] [RED("("levelWeight")] 		public CInt32 LevelWeight { get; set;}

		[Ordinal(0)] [RED("("tweakWeight")] 		public CFloat TweakWeight { get; set;}

		public CScriptSoundSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CScriptSoundSystem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}