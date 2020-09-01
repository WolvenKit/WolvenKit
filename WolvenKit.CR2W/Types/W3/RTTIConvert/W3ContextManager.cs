using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ContextManager : CObject
	{
		[Ordinal(0)] [RED("("m_currentContext")] 		public CHandle<W3UIContext> M_currentContext { get; set;}

		[Ordinal(0)] [RED("("m_commonMenuRef")] 		public CHandle<CR4CommonMenu> M_commonMenuRef { get; set;}

		public W3ContextManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ContextManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}