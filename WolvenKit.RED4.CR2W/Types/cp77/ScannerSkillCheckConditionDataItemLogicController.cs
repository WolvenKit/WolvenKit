using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckConditionDataItemLogicController : inkWidgetLogicController
	{
		private CName _conditionDataDescriptionName;
		private inkWidgetPath _parentConditionTextPath;
		private inkWidgetPath _ownConditionTextPath;
		private inkWidgetPath _conditionDescriptionListPath;
		private CArray<wCHandle<inkWidget>> _conditionDescriptions;
		private wCHandle<inkTextWidget> _parentConditionText;
		private wCHandle<inkTextWidget> _ownConditionText;
		private wCHandle<inkCompoundWidget> _conditionDescriptionList;

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
		public CArray<wCHandle<inkWidget>> ConditionDescriptions
		{
			get => GetProperty(ref _conditionDescriptions);
			set => SetProperty(ref _conditionDescriptions, value);
		}

		[Ordinal(6)] 
		[RED("ParentConditionText")] 
		public wCHandle<inkTextWidget> ParentConditionText
		{
			get => GetProperty(ref _parentConditionText);
			set => SetProperty(ref _parentConditionText, value);
		}

		[Ordinal(7)] 
		[RED("OwnConditionText")] 
		public wCHandle<inkTextWidget> OwnConditionText
		{
			get => GetProperty(ref _ownConditionText);
			set => SetProperty(ref _ownConditionText, value);
		}

		[Ordinal(8)] 
		[RED("ConditionDescriptionList")] 
		public wCHandle<inkCompoundWidget> ConditionDescriptionList
		{
			get => GetProperty(ref _conditionDescriptionList);
			set => SetProperty(ref _conditionDescriptionList, value);
		}

		public ScannerSkillCheckConditionDataItemLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
