using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTopBarHeader : inkButtonController
	{
		[Ordinal(10)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(11)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(12)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(13)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public CharacterCreationTopBarHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
