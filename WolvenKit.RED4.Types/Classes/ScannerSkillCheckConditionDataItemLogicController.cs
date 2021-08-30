using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerSkillCheckConditionDataItemLogicController : inkWidgetLogicController
	{
		private CName _conditionDataDescriptionName;
		private inkWidgetPath _parentConditionTextPath;
		private inkWidgetPath _ownConditionTextPath;
		private inkWidgetPath _conditionDescriptionListPath;
		private CArray<CWeakHandle<inkWidget>> _conditionDescriptions;
		private CWeakHandle<inkTextWidget> _parentConditionText;
		private CWeakHandle<inkTextWidget> _ownConditionText;
		private CWeakHandle<inkCompoundWidget> _conditionDescriptionList;

		[Ordinal(1)] 
		[RED("ConditionDataDescriptionName")] 
		public CName ConditionDataDescriptionName
		{
			get => GetProperty(ref _conditionDataDescriptionName);
			set => SetProperty(ref _conditionDataDescriptionName, value);
		}

		[Ordinal(2)] 
		[RED("ParentConditionTextPath")] 
		public inkWidgetPath ParentConditionTextPath
		{
			get => GetProperty(ref _parentConditionTextPath);
			set => SetProperty(ref _parentConditionTextPath, value);
		}

		[Ordinal(3)] 
		[RED("OwnConditionTextPath")] 
		public inkWidgetPath OwnConditionTextPath
		{
			get => GetProperty(ref _ownConditionTextPath);
			set => SetProperty(ref _ownConditionTextPath, value);
		}

		[Ordinal(4)] 
		[RED("ConditionDescriptionListPath")] 
		public inkWidgetPath ConditionDescriptionListPath
		{
			get => GetProperty(ref _conditionDescriptionListPath);
			set => SetProperty(ref _conditionDescriptionListPath, value);
		}

		[Ordinal(5)] 
		[RED("ConditionDescriptions")] 
		public CArray<CWeakHandle<inkWidget>> ConditionDescriptions
		{
			get => GetProperty(ref _conditionDescriptions);
			set => SetProperty(ref _conditionDescriptions, value);
		}

		[Ordinal(6)] 
		[RED("ParentConditionText")] 
		public CWeakHandle<inkTextWidget> ParentConditionText
		{
			get => GetProperty(ref _parentConditionText);
			set => SetProperty(ref _parentConditionText, value);
		}

		[Ordinal(7)] 
		[RED("OwnConditionText")] 
		public CWeakHandle<inkTextWidget> OwnConditionText
		{
			get => GetProperty(ref _ownConditionText);
			set => SetProperty(ref _ownConditionText, value);
		}

		[Ordinal(8)] 
		[RED("ConditionDescriptionList")] 
		public CWeakHandle<inkCompoundWidget> ConditionDescriptionList
		{
			get => GetProperty(ref _conditionDescriptionList);
			set => SetProperty(ref _conditionDescriptionList, value);
		}

		public ScannerSkillCheckConditionDataItemLogicController()
		{
			_conditionDataDescriptionName = "ConditionDataDescription";
		}
	}
}
