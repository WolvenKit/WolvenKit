using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToGiantWeaponMonitor : IBehTreeTask
	{
		[Ordinal(1)] [RED("effectResourceName")] 		public CName EffectResourceName { get; set;}

		[Ordinal(2)] [RED("playFxOnEffectEntity")] 		public CName PlayFxOnEffectEntity { get; set;}

		[Ordinal(3)] [RED("spawnZOffset")] 		public CFloat SpawnZOffset { get; set;}

		[Ordinal(4)] [RED("effectEntity")] 		public CHandle<CEntityTemplate> EffectEntity { get; set;}

		[Ordinal(5)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(6)] [RED("victimsArray", 2,0)] 		public CArray<CHandle<CActor>> VictimsArray { get; set;}

		[Ordinal(7)] [RED("actorEventReceived")] 		public CBool ActorEventReceived { get; set;}

		[Ordinal(8)] [RED("entityPos")] 		public Vector EntityPos { get; set;}

		[Ordinal(9)] [RED("entityRot")] 		public EulerAngles EntityRot { get; set;}

		public CBTTaskReactionToGiantWeaponMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToGiantWeaponMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}