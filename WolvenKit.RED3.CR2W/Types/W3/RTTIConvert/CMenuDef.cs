using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMenuDef : CObject
	{
		[Ordinal(1)] [RED("timeParam")] 		public CPtr<IMenuTimeParam> TimeParam { get; set;}

		[Ordinal(2)] [RED("backgroundVideoParam")] 		public CPtr<IMenuBackgroundVideoParam> BackgroundVideoParam { get; set;}

		[Ordinal(3)] [RED("renderParam")] 		public CPtr<IMenuDisplayParam> RenderParam { get; set;}

		public CMenuDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}