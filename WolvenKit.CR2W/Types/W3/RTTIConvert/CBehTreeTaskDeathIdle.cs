using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathIdle : IBehTreeTask
	{
		[Ordinal(0)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(0)] [RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[Ordinal(0)] [RED("disableRagdollAfter")] 		public CFloat DisableRagdollAfter { get; set;}

		[Ordinal(0)] [RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(0)] [RED("disableCollisionDelay")] 		public CFloat DisableCollisionDelay { get; set;}

		[Ordinal(0)] [RED("tag", 2,0)] 		public CArray<CName> Tag { get; set;}

		[Ordinal(0)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		public CBehTreeTaskDeathIdle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathIdle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}