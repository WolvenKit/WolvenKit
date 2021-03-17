using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsEnableSkipCredits_NodeType : questIUIManagerNodeType
	{
		private CBool _enableSkipping;

		[Ordinal(0)] 
		[RED("enableSkipping")] 
		public CBool EnableSkipping
		{
			get => GetProperty(ref _enableSkipping);
			set => SetProperty(ref _enableSkipping, value);
		}

		public questFinalBoardsEnableSkipCredits_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
