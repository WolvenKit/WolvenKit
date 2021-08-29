using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorMappingExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIArgumentMapping> _mapping;
		private CBool _update;
		private CFloat _updatePeriod;
		private CArray<CName> _behaviorCallbackNames;

		[Ordinal(0)] 
		[RED("mapping")] 
		public CHandle<AIArgumentMapping> Mapping
		{
			get => GetProperty(ref _mapping);
			set => SetProperty(ref _mapping, value);
		}

		[Ordinal(1)] 
		[RED("update")] 
		public CBool Update
		{
			get => GetProperty(ref _update);
			set => SetProperty(ref _update, value);
		}

		[Ordinal(2)] 
		[RED("updatePeriod")] 
		public CFloat UpdatePeriod
		{
			get => GetProperty(ref _updatePeriod);
			set => SetProperty(ref _updatePeriod, value);
		}

		[Ordinal(3)] 
		[RED("behaviorCallbackNames")] 
		public CArray<CName> BehaviorCallbackNames
		{
			get => GetProperty(ref _behaviorCallbackNames);
			set => SetProperty(ref _behaviorCallbackNames, value);
		}
	}
}
