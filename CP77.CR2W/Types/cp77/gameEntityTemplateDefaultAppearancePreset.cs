using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEntityTemplateDefaultAppearancePreset : ISerializable
	{
		[Ordinal(0)]  [RED("defaultAppearancePresets")] public CArray<gameDefaultAppearancePreset_Entity> DefaultAppearancePresets { get; set; }

		public gameEntityTemplateDefaultAppearancePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
