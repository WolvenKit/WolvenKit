using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathState : IBehTreeTask
	{
		[Ordinal(0)] [RED("destroyAfterAnimDelay")] 		public CFloat DestroyAfterAnimDelay { get; set;}

		[Ordinal(0)] [RED("destroyAnimEvent")] 		public CBool DestroyAnimEvent { get; set;}

		[Ordinal(0)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(0)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(0)] [RED("createReactionEvent")] 		public CName CreateReactionEvent { get; set;}

		[Ordinal(0)] [RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[Ordinal(0)] [RED("saveLockID")] 		public CInt32 SaveLockID { get; set;}

		[Ordinal(0)] [RED("dropWeapons")] 		public CBool DropWeapons { get; set;}

		[Ordinal(0)] [RED("deadDestructSquaredDist")] 		public CFloat DeadDestructSquaredDist { get; set;}

		public CBehTreeTaskDeathState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}