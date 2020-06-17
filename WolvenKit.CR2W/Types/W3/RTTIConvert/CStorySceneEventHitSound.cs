using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventHitSound : CStorySceneEvent
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("actorAttacker")] 		public CName ActorAttacker { get; set;}

		[RED("soundAttackType")] 		public CName SoundAttackType { get; set;}

		[RED("actorAttackerWeaponSlot")] 		public CName ActorAttackerWeaponSlot { get; set;}

		[RED("actorAttackerWeaponName")] 		public CName ActorAttackerWeaponName { get; set;}

		public CStorySceneEventHitSound(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventHitSound(cr2w);

	}
}