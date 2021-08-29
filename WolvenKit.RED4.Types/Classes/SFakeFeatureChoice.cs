using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SFakeFeatureChoice : RedBaseClass
	{
		private CString _choiceID;
		private CBool _isEnabled;
		private CBool _disableOnUse;
		private CName _factToEnableName;
		private SFactOperationData _factOnUse;
		private CArray<SFactOperationData> _factsOnUse;
		private CArray<SComponentOperationData> _affectedComponents;
		private CUInt32 _callbackID;

		[Ordinal(0)] 
		[RED("choiceID")] 
		public CString ChoiceID
		{
			get => GetProperty(ref _choiceID);
			set => SetProperty(ref _choiceID, value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(2)] 
		[RED("disableOnUse")] 
		public CBool DisableOnUse
		{
			get => GetProperty(ref _disableOnUse);
			set => SetProperty(ref _disableOnUse, value);
		}

		[Ordinal(3)] 
		[RED("factToEnableName")] 
		public CName FactToEnableName
		{
			get => GetProperty(ref _factToEnableName);
			set => SetProperty(ref _factToEnableName, value);
		}

		[Ordinal(4)] 
		[RED("factOnUse")] 
		public SFactOperationData FactOnUse
		{
			get => GetProperty(ref _factOnUse);
			set => SetProperty(ref _factOnUse, value);
		}

		[Ordinal(5)] 
		[RED("factsOnUse")] 
		public CArray<SFactOperationData> FactsOnUse
		{
			get => GetProperty(ref _factsOnUse);
			set => SetProperty(ref _factsOnUse, value);
		}

		[Ordinal(6)] 
		[RED("affectedComponents")] 
		public CArray<SComponentOperationData> AffectedComponents
		{
			get => GetProperty(ref _affectedComponents);
			set => SetProperty(ref _affectedComponents, value);
		}

		[Ordinal(7)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}
	}
}
