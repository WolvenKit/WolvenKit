using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemSetBackpackSorting : gameScriptableSystemRequest
	{
		private CInt32 _sortMode;

		[Ordinal(0)] 
		[RED("sortMode")] 
		public CInt32 SortMode
		{
			get => GetProperty(ref _sortMode);
			set => SetProperty(ref _sortMode, value);
		}

		public UIScriptableSystemSetBackpackSorting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
