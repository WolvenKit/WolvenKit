using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemSetBackpackFilter : gameScriptableSystemRequest
	{
		private CInt32 _filterMode;

		[Ordinal(0)] 
		[RED("filterMode")] 
		public CInt32 FilterMode
		{
			get => GetProperty(ref _filterMode);
			set => SetProperty(ref _filterMode, value);
		}

		public UIScriptableSystemSetBackpackFilter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
