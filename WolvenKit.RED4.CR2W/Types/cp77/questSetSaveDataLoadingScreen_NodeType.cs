using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetSaveDataLoadingScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("selectedLoading")] public TweakDBID SelectedLoading { get; set; }

		public questSetSaveDataLoadingScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
