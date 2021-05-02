using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ContextManager : CObject
	{
		[Ordinal(1)] [RED("m_currentContext")] 		public CHandle<W3UIContext> M_currentContext { get; set;}

		[Ordinal(2)] [RED("m_commonMenuRef")] 		public CHandle<CR4CommonMenu> M_commonMenuRef { get; set;}

		public W3ContextManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ContextManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}