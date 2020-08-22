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
		[RED("destroyAfterAnimDelay")] 		public CFloat DestroyAfterAnimDelay { get; set;}

		[RED("destroyAnimEvent")] 		public CBool DestroyAnimEvent { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[RED("createReactionEvent")] 		public CName CreateReactionEvent { get; set;}

		[RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[RED("saveLockID")] 		public CInt32 SaveLockID { get; set;}

		[RED("dropWeapons")] 		public CBool DropWeapons { get; set;}

		[RED("deadDestructSquaredDist")] 		public CFloat DeadDestructSquaredDist { get; set;}

		public CBehTreeTaskDeathState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}