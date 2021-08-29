using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimParamSlotsOption : RedBaseClass
	{
		private TweakDBID _slotID;
		private CName _paramName;
		private CEnum<entAnimParamSlotFunction> _function;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetProperty(ref _paramName);
			set => SetProperty(ref _paramName, value);
		}

		[Ordinal(2)] 
		[RED("function")] 
		public CEnum<entAnimParamSlotFunction> Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}
	}
}
