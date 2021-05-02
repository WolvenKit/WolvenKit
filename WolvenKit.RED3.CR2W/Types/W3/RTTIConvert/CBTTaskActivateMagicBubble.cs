using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskActivateMagicBubble : IBehTreeTask
	{
		[Ordinal(1)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(2)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(3)] [RED("animEventName")] 		public CName AnimEventName { get; set;}

		[Ordinal(4)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(5)] [RED("spawnedEntity")] 		public CHandle<CEntity> SpawnedEntity { get; set;}

		public CBTTaskActivateMagicBubble(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskActivateMagicBubble(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}