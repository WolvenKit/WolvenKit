using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAxiiCharmMonitor : IBehTreeTask
	{
		[Ordinal(1)] [RED("wasCharmed")] 		public CBool WasCharmed { get; set;}

		[Ordinal(2)] [RED("removeCharmCooldown")] 		public CFloat RemoveCharmCooldown { get; set;}

		public CBTTaskAxiiCharmMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAxiiCharmMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}