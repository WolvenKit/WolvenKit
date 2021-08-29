using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interactionItemLogicController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _inputButtonContainer;
		private inkWidgetReference _inputDisplayControllerRef;
		private inkWidgetReference _quickHackCostHolder;
		private inkTextWidgetReference _quickHackCost;
		private inkImageWidgetReference _quickHackIcon;
		private inkCompoundWidgetReference _quickHackHolder;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _labelFail;
		private inkWidgetReference _skillCheckPassBG;
		private inkWidgetReference _skillCheckFailBG;
		private inkWidgetReference _qHIllegalIndicator;
		private inkWidgetReference _sCIllegalIndicator;
		private inkWidgetReference _additionalReqsNeeded;
		private inkCompoundWidgetReference _skillCheck;
		private inkCompoundWidgetReference _skillCheckNormalReqs;
		private inkImageWidgetReference _skillCheckIcon;
		private inkTextWidgetReference _skillCheckText;
		private CWeakHandle<inkCompoundWidget> _rootWidget;
		private CFloat _inActiveTransparency;
		private CWeakHandle<inkInputDisplayController> _inputDisplayController;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _isSelected;

		[Ordinal(1)] 
		[RED("inputButtonContainer")] 
		public inkCompoundWidgetReference InputButtonContainer
		{
			get => GetProperty(ref _inputButtonContainer);
			set => SetProperty(ref _inputButtonContainer, value);
		}

		[Ordinal(2)] 
		[RED("inputDisplayControllerRef")] 
		public inkWidgetReference InputDisplayControllerRef
		{
			get => GetProperty(ref _inputDisplayControllerRef);
			set => SetProperty(ref _inputDisplayControllerRef, value);
		}

		[Ordinal(3)] 
		[RED("QuickHackCostHolder")] 
		public inkWidgetReference QuickHackCostHolder
		{
			get => GetProperty(ref _quickHackCostHolder);
			set => SetProperty(ref _quickHackCostHolder, value);
		}

		[Ordinal(4)] 
		[RED("QuickHackCost")] 
		public inkTextWidgetReference QuickHackCost
		{
			get => GetProperty(ref _quickHackCost);
			set => SetProperty(ref _quickHackCost, value);
		}

		[Ordinal(5)] 
		[RED("QuickHackIcon")] 
		public inkImageWidgetReference QuickHackIcon
		{
			get => GetProperty(ref _quickHackIcon);
			set => SetProperty(ref _quickHackIcon, value);
		}

		[Ordinal(6)] 
		[RED("QuickHackHolder")] 
		public inkCompoundWidgetReference QuickHackHolder
		{
			get => GetProperty(ref _quickHackHolder);
			set => SetProperty(ref _quickHackHolder, value);
		}

		[Ordinal(7)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(8)] 
		[RED("labelFail")] 
		public inkTextWidgetReference LabelFail
		{
			get => GetProperty(ref _labelFail);
			set => SetProperty(ref _labelFail, value);
		}

		[Ordinal(9)] 
		[RED("SkillCheckPassBG")] 
		public inkWidgetReference SkillCheckPassBG
		{
			get => GetProperty(ref _skillCheckPassBG);
			set => SetProperty(ref _skillCheckPassBG, value);
		}

		[Ordinal(10)] 
		[RED("SkillCheckFailBG")] 
		public inkWidgetReference SkillCheckFailBG
		{
			get => GetProperty(ref _skillCheckFailBG);
			set => SetProperty(ref _skillCheckFailBG, value);
		}

		[Ordinal(11)] 
		[RED("QHIllegalIndicator")] 
		public inkWidgetReference QHIllegalIndicator
		{
			get => GetProperty(ref _qHIllegalIndicator);
			set => SetProperty(ref _qHIllegalIndicator, value);
		}

		[Ordinal(12)] 
		[RED("SCIllegalIndicator")] 
		public inkWidgetReference SCIllegalIndicator
		{
			get => GetProperty(ref _sCIllegalIndicator);
			set => SetProperty(ref _sCIllegalIndicator, value);
		}

		[Ordinal(13)] 
		[RED("additionalReqsNeeded")] 
		public inkWidgetReference AdditionalReqsNeeded
		{
			get => GetProperty(ref _additionalReqsNeeded);
			set => SetProperty(ref _additionalReqsNeeded, value);
		}

		[Ordinal(14)] 
		[RED("skillCheck")] 
		public inkCompoundWidgetReference SkillCheck
		{
			get => GetProperty(ref _skillCheck);
			set => SetProperty(ref _skillCheck, value);
		}

		[Ordinal(15)] 
		[RED("skillCheckNormalReqs")] 
		public inkCompoundWidgetReference SkillCheckNormalReqs
		{
			get => GetProperty(ref _skillCheckNormalReqs);
			set => SetProperty(ref _skillCheckNormalReqs, value);
		}

		[Ordinal(16)] 
		[RED("skillCheckIcon")] 
		public inkImageWidgetReference SkillCheckIcon
		{
			get => GetProperty(ref _skillCheckIcon);
			set => SetProperty(ref _skillCheckIcon, value);
		}

		[Ordinal(17)] 
		[RED("skillCheckText")] 
		public inkTextWidgetReference SkillCheckText
		{
			get => GetProperty(ref _skillCheckText);
			set => SetProperty(ref _skillCheckText, value);
		}

		[Ordinal(18)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(19)] 
		[RED("inActiveTransparency")] 
		public CFloat InActiveTransparency
		{
			get => GetProperty(ref _inActiveTransparency);
			set => SetProperty(ref _inActiveTransparency, value);
		}

		[Ordinal(20)] 
		[RED("inputDisplayController")] 
		public CWeakHandle<inkInputDisplayController> InputDisplayController
		{
			get => GetProperty(ref _inputDisplayController);
			set => SetProperty(ref _inputDisplayController, value);
		}

		[Ordinal(21)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(22)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}
	}
}
