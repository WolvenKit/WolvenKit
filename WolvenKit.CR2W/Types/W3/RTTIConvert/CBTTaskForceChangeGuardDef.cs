using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskForceChangeGuardDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDectivate")] 		public CBool OnDectivate { get; set;}

		[Ordinal(0)] [RED("("raiseGuard")] 		public CBool RaiseGuard { get; set;}

		[Ordinal(0)] [RED("("lowerGuard")] 		public CBool LowerGuard { get; set;}

		public CBTTaskForceChangeGuardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskForceChangeGuardDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}