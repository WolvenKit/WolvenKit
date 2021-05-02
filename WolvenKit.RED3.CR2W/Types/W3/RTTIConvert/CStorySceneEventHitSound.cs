using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventHitSound : CStorySceneEvent
	{
		[Ordinal(1)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("actorAttacker")] 		public CName ActorAttacker { get; set;}

		[Ordinal(3)] [RED("soundAttackType")] 		public CName SoundAttackType { get; set;}

		[Ordinal(4)] [RED("actorAttackerWeaponSlot")] 		public CName ActorAttackerWeaponSlot { get; set;}

		[Ordinal(5)] [RED("actorAttackerWeaponName")] 		public CName ActorAttackerWeaponName { get; set;}

		public CStorySceneEventHitSound(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}