using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetSaveDataLoadingScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("selectedLoading")] public TweakDBID SelectedLoading { get; set; }

		public questSetSaveDataLoadingScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
