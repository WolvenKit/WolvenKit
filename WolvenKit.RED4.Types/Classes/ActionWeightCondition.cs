using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionWeightCondition : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _selectedActionIndex;
		private CInt32 _thisIndex;

		[Ordinal(0)] 
		[RED("selectedActionIndex")] 
		public CHandle<AIArgumentMapping> SelectedActionIndex
		{
			get => GetProperty(ref _selectedActionIndex);
			set => SetProperty(ref _selectedActionIndex, value);
		}

		[Ordinal(1)] 
		[RED("thisIndex")] 
		public CInt32 ThisIndex
		{
			get => GetProperty(ref _thisIndex);
			set => SetProperty(ref _thisIndex, value);
		}
	}
}
