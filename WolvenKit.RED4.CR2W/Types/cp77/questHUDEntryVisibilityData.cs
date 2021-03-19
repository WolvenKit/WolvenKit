using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityData : CVariable
	{
		private CName _hudEntryName;
		private CEnum<worlduiEntryVisibility> _visibility;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetProperty(ref _hudEntryName);
			set => SetProperty(ref _hudEntryName, value);
		}

		[Ordinal(1)] 
		[RED("visibility")] 
		public CEnum<worlduiEntryVisibility> Visibility
		{
			get => GetProperty(ref _visibility);
			set => SetProperty(ref _visibility, value);
		}

		public questHUDEntryVisibilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
