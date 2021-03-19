using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverride : CVariable
	{
		private CArray<workWorkspotItemOverridePropOverride> _propOverrides;
		private CArray<workWorkspotItemOverrideItemOverride> _itemOverrides;

		[Ordinal(0)] 
		[RED("propOverrides")] 
		public CArray<workWorkspotItemOverridePropOverride> PropOverrides
		{
			get => GetProperty(ref _propOverrides);
			set => SetProperty(ref _propOverrides, value);
		}

		[Ordinal(1)] 
		[RED("itemOverrides")] 
		public CArray<workWorkspotItemOverrideItemOverride> ItemOverrides
		{
			get => GetProperty(ref _itemOverrides);
			set => SetProperty(ref _itemOverrides, value);
		}

		public workWorkspotItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
