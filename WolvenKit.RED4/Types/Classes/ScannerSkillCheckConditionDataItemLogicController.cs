using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerSkillCheckConditionDataItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ConditionDataDescriptionName")] 
		public CName ConditionDataDescriptionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ParentConditionTextPath")] 
		public inkWidgetPath ParentConditionTextPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(3)] 
		[RED("OwnConditionTextPath")] 
		public inkWidgetPath OwnConditionTextPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(4)] 
		[RED("ConditionDescriptionListPath")] 
		public inkWidgetPath ConditionDescriptionListPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(5)] 
		[RED("ConditionDescriptions")] 
		public CArray<CWeakHandle<inkWidget>> ConditionDescriptions
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(6)] 
		[RED("ParentConditionText")] 
		public CWeakHandle<inkTextWidget> ParentConditionText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("OwnConditionText")] 
		public CWeakHandle<inkTextWidget> OwnConditionText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("ConditionDescriptionList")] 
		public CWeakHandle<inkCompoundWidget> ConditionDescriptionList
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public ScannerSkillCheckConditionDataItemLogicController()
		{
			ConditionDataDescriptionName = "ConditionDataDescription";
			ParentConditionTextPath = new inkWidgetPath { Names = new() };
			OwnConditionTextPath = new inkWidgetPath { Names = new() };
			ConditionDescriptionListPath = new inkWidgetPath { Names = new() };
			ConditionDescriptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
