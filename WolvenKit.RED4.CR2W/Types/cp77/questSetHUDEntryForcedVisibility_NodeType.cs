using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetHUDEntryForcedVisibility_NodeType : questIUIManagerNodeType
	{
		private CArray<CName> _hudEntryName;
		private CBool _usePreset;
		private TweakDBID _hudVisibilityPreset;
		private CEnum<worlduiEntryVisibility> _visibility;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CArray<CName> HudEntryName
		{
			get => GetProperty(ref _hudEntryName);
			set => SetProperty(ref _hudEntryName, value);
		}

		[Ordinal(1)] 
		[RED("usePreset")] 
		public CBool UsePreset
		{
			get => GetProperty(ref _usePreset);
			set => SetProperty(ref _usePreset, value);
		}

		[Ordinal(2)] 
		[RED("hudVisibilityPreset")] 
		public TweakDBID HudVisibilityPreset
		{
			get => GetProperty(ref _hudVisibilityPreset);
			set => SetProperty(ref _hudVisibilityPreset, value);
		}

		[Ordinal(3)] 
		[RED("visibility")] 
		public CEnum<worlduiEntryVisibility> Visibility
		{
			get => GetProperty(ref _visibility);
			set => SetProperty(ref _visibility, value);
		}

		public questSetHUDEntryForcedVisibility_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
