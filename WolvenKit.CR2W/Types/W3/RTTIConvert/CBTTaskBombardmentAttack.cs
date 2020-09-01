using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBombardmentAttack : IBehTreeTask
	{
		[Ordinal(1)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("performBombardment")] 		public CBool PerformBombardment { get; set;}

		[Ordinal(3)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(4)] [RED("resourceName")] 		public CString ResourceName { get; set;}

		[Ordinal(5)] [RED("afterSpawnDelay")] 		public CFloat AfterSpawnDelay { get; set;}

		[Ordinal(6)] [RED("initialDelay")] 		public CFloat InitialDelay { get; set;}

		[Ordinal(7)] [RED("yOffset")] 		public CFloat YOffset { get; set;}

		[Ordinal(8)] [RED("fxName")] 		public CName FxName { get; set;}

		public CBTTaskBombardmentAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBombardmentAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}