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
		[RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[RED("changeAppearanceAfter")] 		public CFloat ChangeAppearanceAfter { get; set;}

		[RED("disableRagdollAfter")] 		public CFloat DisableRagdollAfter { get; set;}

		[RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[RED("disableCollisionDelay")] 		public CFloat DisableCollisionDelay { get; set;}

		[RED("tag", 2,0)] 		public CArray<CName> Tag { get; set;}

		[RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		public CBehTreeTaskDeathIdle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathIdle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}