using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDropLoot : IBehTreeTask
	{
		[Ordinal(1)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(2)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(3)] [RED("lootDropped")] 		public CBool LootDropped { get; set;}

		[Ordinal(4)] [RED("attacker")] 		public CHandle<CGameplayEntity> Attacker { get; set;}

		[Ordinal(5)] [RED("causer")] 		public CHandle<IScriptable> Causer { get; set;}

		[Ordinal(6)] [RED("saveLockID")] 		public CInt32 SaveLockID { get; set;}

		public CBTTaskDropLoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDropLoot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}