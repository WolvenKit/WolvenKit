using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondIsVisibleDef : IBehTreeConditionalTaskDefinition
	{
		[RED("gameplayVisibility")] 		public CBool GameplayVisibility { get; set;}

		[RED("meshVisibility")] 		public CBool MeshVisibility { get; set;}

		[RED("forceComplete")] 		public CBool ForceComplete { get; set;}

		[RED("target")] 		public CBool Target { get; set;}

		[RED("invert")] 		public CBool Invert { get; set;}

		public CBTCondIsVisibleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondIsVisibleDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}