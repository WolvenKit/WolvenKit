using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemController : inkWidgetLogicController
	{
		private inkWidgetReference _attributeDisplay;
		private inkImageWidgetReference _connectionLine;
		private CEnum<PerkMenuAttribute> _attributeType;
		private inkCompoundWidgetReference _skillsLevelsContainer;
		private CArray<inkWidgetReference> _proficiencyButtonRefs;
		private CBool _isReversed;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CHandle<PerksMenuAttributeDisplayController> _attributeDisplayController;
		private CBool _recentlyPurchased;
		private CBool _holdStarted;
		private CHandle<AttributeData> _data;
		private CHandle<inkanimProxy> _cool_in_proxy;
		private CHandle<inkanimProxy> _cool_out_proxy;

		[Ordinal(1)] 
		[RED("attributeDisplay")] 
		public inkWidgetReference AttributeDisplay
		{
			get => GetProperty(ref _attributeDisplay);
			set => SetProperty(ref _attributeDisplay, value);
		}

		[Ordinal(2)] 
		[RED("connectionLine")] 
		public inkImageWidgetReference ConnectionLine
		{
			get => GetProperty(ref _connectionLine);
			set => SetProperty(ref _connectionLine, value);
		}

		[Ordinal(3)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}

		[Ordinal(4)] 
		[RED("skillsLevelsContainer")] 
		public inkCompoundWidgetReference SkillsLevelsContainer
		{
			get => GetProperty(ref _skillsLevelsContainer);
			set => SetProperty(ref _skillsLevelsContainer, value);
		}

		[Ordinal(5)] 
		[RED("proficiencyButtonRefs")] 
		public CArray<inkWidgetReference> ProficiencyButtonRefs
		{
			get => GetProperty(ref _proficiencyButtonRefs);
			set => SetProperty(ref _proficiencyButtonRefs, value);
		}

		[Ordinal(6)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetProperty(ref _isReversed);
			set => SetProperty(ref _isReversed, value);
		}

		[Ordinal(7)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(8)] 
		[RED("attributeDisplayController")] 
		public CHandle<PerksMenuAttributeDisplayController> AttributeDisplayController
		{
			get => GetProperty(ref _attributeDisplayController);
			set => SetProperty(ref _attributeDisplayController, value);
		}

		[Ordinal(9)] 
		[RED("recentlyPurchased")] 
		public CBool RecentlyPurchased
		{
			get => GetProperty(ref _recentlyPurchased);
			set => SetProperty(ref _recentlyPurchased, value);
		}

		[Ordinal(10)] 
		[RED("holdStarted")] 
		public CBool HoldStarted
		{
			get => GetProperty(ref _holdStarted);
			set => SetProperty(ref _holdStarted, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<AttributeData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("cool_in_proxy")] 
		public CHandle<inkanimProxy> Cool_in_proxy
		{
			get => GetProperty(ref _cool_in_proxy);
			set => SetProperty(ref _cool_in_proxy, value);
		}

		[Ordinal(13)] 
		[RED("cool_out_proxy")] 
		public CHandle<inkanimProxy> Cool_out_proxy
		{
			get => GetProperty(ref _cool_out_proxy);
			set => SetProperty(ref _cool_out_proxy, value);
		}

		public PerksMenuAttributeItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
