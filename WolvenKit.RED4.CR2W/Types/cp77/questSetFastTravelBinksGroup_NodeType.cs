using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFastTravelBinksGroup_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("selectedBinkDataGroup")] public TweakDBID SelectedBinkDataGroup { get; set; }

		public questSetFastTravelBinksGroup_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
