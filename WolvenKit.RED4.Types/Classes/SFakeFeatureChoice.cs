using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SFakeFeatureChoice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("choiceID")] 
		public CString ChoiceID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("disableOnUse")] 
		public CBool DisableOnUse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("factToEnableName")] 
		public CName FactToEnableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("factOnUse")] 
		public SFactOperationData FactOnUse
		{
			get => GetPropertyValue<SFactOperationData>();
			set => SetPropertyValue<SFactOperationData>(value);
		}

		[Ordinal(5)] 
		[RED("factsOnUse")] 
		public CArray<SFactOperationData> FactsOnUse
		{
			get => GetPropertyValue<CArray<SFactOperationData>>();
			set => SetPropertyValue<CArray<SFactOperationData>>(value);
		}

		[Ordinal(6)] 
		[RED("affectedComponents")] 
		public CArray<SComponentOperationData> AffectedComponents
		{
			get => GetPropertyValue<CArray<SComponentOperationData>>();
			set => SetPropertyValue<CArray<SComponentOperationData>>(value);
		}

		[Ordinal(7)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public SFakeFeatureChoice()
		{
			FactOnUse = new();
			FactsOnUse = new();
			AffectedComponents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
