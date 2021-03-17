using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationSummaryListItemData : IScriptable
	{
		private CString _label;
		private CString _desc;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("desc")] 
		public CString Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		public CharacterCreationSummaryListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
