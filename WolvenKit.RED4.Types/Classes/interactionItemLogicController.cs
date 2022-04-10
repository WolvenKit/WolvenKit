using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interactionItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("inputButtonContainer")] 
		public inkCompoundWidgetReference InputButtonContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("inputDisplayControllerRef")] 
		public inkWidgetReference InputDisplayControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("QuickHackCostHolder")] 
		public inkWidgetReference QuickHackCostHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("QuickHackCost")] 
		public inkTextWidgetReference QuickHackCost
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("QuickHackIcon")] 
		public inkImageWidgetReference QuickHackIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("QuickHackHolder")] 
		public inkCompoundWidgetReference QuickHackHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("labelFail")] 
		public inkTextWidgetReference LabelFail
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("SkillCheckPassBG")] 
		public inkWidgetReference SkillCheckPassBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("SkillCheckFailBG")] 
		public inkWidgetReference SkillCheckFailBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("QHIllegalIndicator")] 
		public inkWidgetReference QHIllegalIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("SCIllegalIndicator")] 
		public inkWidgetReference SCIllegalIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("additionalReqsNeeded")] 
		public inkWidgetReference AdditionalReqsNeeded
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("skillCheck")] 
		public inkCompoundWidgetReference SkillCheck
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("skillCheckNormalReqs")] 
		public inkCompoundWidgetReference SkillCheckNormalReqs
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("skillCheckIcon")] 
		public inkImageWidgetReference SkillCheckIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("skillCheckText")] 
		public inkTextWidgetReference SkillCheckText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("inActiveTransparency")] 
		public CFloat InActiveTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("inputDisplayController")] 
		public CWeakHandle<inkInputDisplayController> InputDisplayController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(21)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public interactionItemLogicController()
		{
			InputButtonContainer = new();
			InputDisplayControllerRef = new();
			QuickHackCostHolder = new();
			QuickHackCost = new();
			QuickHackIcon = new();
			QuickHackHolder = new();
			Label = new();
			LabelFail = new();
			SkillCheckPassBG = new();
			SkillCheckFailBG = new();
			QHIllegalIndicator = new();
			SCIllegalIndicator = new();
			AdditionalReqsNeeded = new();
			SkillCheck = new();
			SkillCheckNormalReqs = new();
			SkillCheckIcon = new();
			SkillCheckText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
