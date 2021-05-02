using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathState : IBehTreeTask
	{
		[Ordinal(1)] [RED("destroyAfterAnimDelay")] 		public CFloat DestroyAfterAnimDelay { get; set;}

		[Ordinal(2)] [RED("destroyAnimEvent")] 		public CBool DestroyAnimEvent { get; set;}

		[Ordinal(3)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(4)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(5)] [RED("createReactionEvent")] 		public CName CreateReactionEvent { get; set;}

		[Ordinal(6)] [RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[Ordinal(7)] [RED("saveLockID")] 		public CInt32 SaveLockID { get; set;}

		[Ordinal(8)] [RED("dropWeapons")] 		public CBool DropWeapons { get; set;}

		[Ordinal(9)] [RED("deadDestructSquaredDist")] 		public CFloat DeadDestructSquaredDist { get; set;}

		public CBehTreeTaskDeathState(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}