using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskActivateMagicBubble : IBehTreeTask
	{
		[Ordinal(0)] [RED("("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("animEventName")] 		public CName AnimEventName { get; set;}

		[Ordinal(0)] [RED("("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("("spawnedEntity")] 		public CHandle<CEntity> SpawnedEntity { get; set;}

		public CBTTaskActivateMagicBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskActivateMagicBubble(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}