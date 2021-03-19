using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialArea : inkWidgetLogicController
	{
		private CName _bracketID;

		[Ordinal(1)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get => GetProperty(ref _bracketID);
			set => SetProperty(ref _bracketID, value);
		}

		public gameuiTutorialArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
