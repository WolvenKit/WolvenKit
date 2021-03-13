using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Crossbow : RangedWeapon
	{
		[Ordinal(1)] [RED("shotCount")] 		public CInt32 ShotCount { get; set;}

		[Ordinal(2)] [RED("shotCountLimit")] 		public CInt32 ShotCountLimit { get; set;}

		[Ordinal(3)] [RED("reloadAtStartComplete")] 		public CBool ReloadAtStartComplete { get; set;}

		public Crossbow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new Crossbow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}