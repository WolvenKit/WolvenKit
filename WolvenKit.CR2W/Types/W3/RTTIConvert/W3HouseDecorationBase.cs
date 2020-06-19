using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HouseDecorationBase : W3Container
	{
		[RED("m_acceptQuestItems")] 		public CBool M_acceptQuestItems { get; set;}

		[RED("m_decorationEnabled")] 		public CBool M_decorationEnabled { get; set;}

		[RED("m_noItemMessageStringKey")] 		public CName M_noItemMessageStringKey { get; set;}

		public W3HouseDecorationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HouseDecorationBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}