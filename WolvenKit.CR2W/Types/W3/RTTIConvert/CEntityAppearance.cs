using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEntityAppearance : CVariable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("voicetag")] 		public CName Voicetag { get; set;}

		[RED("appearanceParams", 2,0)] 		public CArray<CPtr<CEntityTemplateParam>> AppearanceParams { get; set;}

		[RED("useVertexCollapse")] 		public CBool UseVertexCollapse { get; set;}

		[RED("usesRobe")] 		public CBool UsesRobe { get; set;}

		[RED("wasIncluded")] 		public CBool WasIncluded { get; set;}

		[RED("includedTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> IncludedTemplates { get; set;}

		[RED("collapsedComponents", 2,0)] 		public CArray<CName> CollapsedComponents { get; set;}

		public CEntityAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntityAppearance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}