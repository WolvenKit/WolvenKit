using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryItemAbility : CVariable
	{
		private CName _iconPath;
		private CString _title;
		private CString _description;
		private CHandle<gameUILocalizationDataPackage> _localizationDataPackage;

		[Ordinal(0)] 
		[RED("IconPath")] 
		public CName IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(1)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(3)] 
		[RED("LocalizationDataPackage")] 
		public CHandle<gameUILocalizationDataPackage> LocalizationDataPackage
		{
			get => GetProperty(ref _localizationDataPackage);
			set => SetProperty(ref _localizationDataPackage, value);
		}

		public gameInventoryItemAbility(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
