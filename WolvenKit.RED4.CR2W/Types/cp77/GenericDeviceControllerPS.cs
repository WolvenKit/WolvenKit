using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isRecognizableBySenses;
		private GenericDeviceActionsData _genericDeviceActionsSetup;
		private CHandle<GenericContainer> _genericDeviceSkillChecks;
		private TweakDBID _deviceWidgetRecord;
		private TweakDBID _thumbnailWidgetRecord;
		private CArray<CName> _performedCustomActionsIDs;

		[Ordinal(104)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get => GetProperty(ref _isRecognizableBySenses);
			set => SetProperty(ref _isRecognizableBySenses, value);
		}

		[Ordinal(105)] 
		[RED("genericDeviceActionsSetup")] 
		public GenericDeviceActionsData GenericDeviceActionsSetup
		{
			get => GetProperty(ref _genericDeviceActionsSetup);
			set => SetProperty(ref _genericDeviceActionsSetup, value);
		}

		[Ordinal(106)] 
		[RED("genericDeviceSkillChecks")] 
		public CHandle<GenericContainer> GenericDeviceSkillChecks
		{
			get => GetProperty(ref _genericDeviceSkillChecks);
			set => SetProperty(ref _genericDeviceSkillChecks, value);
		}

		[Ordinal(107)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetProperty(ref _deviceWidgetRecord);
			set => SetProperty(ref _deviceWidgetRecord, value);
		}

		[Ordinal(108)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get => GetProperty(ref _thumbnailWidgetRecord);
			set => SetProperty(ref _thumbnailWidgetRecord, value);
		}

		[Ordinal(109)] 
		[RED("performedCustomActionsIDs")] 
		public CArray<CName> PerformedCustomActionsIDs
		{
			get => GetProperty(ref _performedCustomActionsIDs);
			set => SetProperty(ref _performedCustomActionsIDs, value);
		}

		public GenericDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
