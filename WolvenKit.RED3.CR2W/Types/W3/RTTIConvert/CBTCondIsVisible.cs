using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondIsVisible : IBehTreeTask
	{
		[Ordinal(1)] [RED("gameplayVisibility")] 		public CBool GameplayVisibility { get; set;}

		[Ordinal(2)] [RED("meshVisibility")] 		public CBool MeshVisibility { get; set;}

		[Ordinal(3)] [RED("forceComplete")] 		public CBool ForceComplete { get; set;}

		[Ordinal(4)] [RED("target")] 		public CBool Target { get; set;}

		[Ordinal(5)] [RED("invert")] 		public CBool Invert { get; set;}

		public CBTCondIsVisible(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondIsVisible(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}