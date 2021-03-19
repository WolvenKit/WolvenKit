using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackDescriptionGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _subHeader;
		private inkTextWidgetReference _tier;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _recompileTimer;
		private inkTextWidgetReference _duration;
		private inkTextWidgetReference _cooldown;
		private inkTextWidgetReference _uploadTime;
		private inkTextWidgetReference _memoryCost;
		private inkTextWidgetReference _memoryRawCost;
		private inkTextWidgetReference _categoryText;
		private inkWidgetReference _categoryContainer;
		private inkWidgetReference _damageWrapper;
		private inkTextWidgetReference _damageLabel;
		private inkTextWidgetReference _damageValue;
		private inkTextWidgetReference _healthPercentageLabel;
		private CUInt32 _quickHackDataCallbackID;
		private CHandle<QuickhackData> _selectedData;

		[Ordinal(5)] 
		[RED("subHeader")] 
		public inkTextWidgetReference SubHeader
		{
			get => GetProperty(ref _subHeader);
			set => SetProperty(ref _subHeader, value);
		}

		[Ordinal(6)] 
		[RED("tier")] 
		public inkTextWidgetReference Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(8)] 
		[RED("recompileTimer")] 
		public inkTextWidgetReference RecompileTimer
		{
			get => GetProperty(ref _recompileTimer);
			set => SetProperty(ref _recompileTimer, value);
		}

		[Ordinal(9)] 
		[RED("duration")] 
		public inkTextWidgetReference Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(10)] 
		[RED("cooldown")] 
		public inkTextWidgetReference Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(11)] 
		[RED("uploadTime")] 
		public inkTextWidgetReference UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		[Ordinal(12)] 
		[RED("memoryCost")] 
		public inkTextWidgetReference MemoryCost
		{
			get => GetProperty(ref _memoryCost);
			set => SetProperty(ref _memoryCost, value);
		}

		[Ordinal(13)] 
		[RED("memoryRawCost")] 
		public inkTextWidgetReference MemoryRawCost
		{
			get => GetProperty(ref _memoryRawCost);
			set => SetProperty(ref _memoryRawCost, value);
		}

		[Ordinal(14)] 
		[RED("categoryText")] 
		public inkTextWidgetReference CategoryText
		{
			get => GetProperty(ref _categoryText);
			set => SetProperty(ref _categoryText, value);
		}

		[Ordinal(15)] 
		[RED("categoryContainer")] 
		public inkWidgetReference CategoryContainer
		{
			get => GetProperty(ref _categoryContainer);
			set => SetProperty(ref _categoryContainer, value);
		}

		[Ordinal(16)] 
		[RED("damageWrapper")] 
		public inkWidgetReference DamageWrapper
		{
			get => GetProperty(ref _damageWrapper);
			set => SetProperty(ref _damageWrapper, value);
		}

		[Ordinal(17)] 
		[RED("damageLabel")] 
		public inkTextWidgetReference DamageLabel
		{
			get => GetProperty(ref _damageLabel);
			set => SetProperty(ref _damageLabel, value);
		}

		[Ordinal(18)] 
		[RED("damageValue")] 
		public inkTextWidgetReference DamageValue
		{
			get => GetProperty(ref _damageValue);
			set => SetProperty(ref _damageValue, value);
		}

		[Ordinal(19)] 
		[RED("healthPercentageLabel")] 
		public inkTextWidgetReference HealthPercentageLabel
		{
			get => GetProperty(ref _healthPercentageLabel);
			set => SetProperty(ref _healthPercentageLabel, value);
		}

		[Ordinal(20)] 
		[RED("quickHackDataCallbackID")] 
		public CUInt32 QuickHackDataCallbackID
		{
			get => GetProperty(ref _quickHackDataCallbackID);
			set => SetProperty(ref _quickHackDataCallbackID, value);
		}

		[Ordinal(21)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		public QuickHackDescriptionGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
