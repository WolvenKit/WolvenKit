using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatorControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("spiderbotInteractionLocationOverride")] 
		public NodeRef SpiderbotInteractionLocationOverride
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(110)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(112)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(113)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(114)] 
		[RED("activatorSkillChecks")] 
		public CHandle<GenericContainer> ActivatorSkillChecks
		{
			get => GetPropertyValue<CHandle<GenericContainer>>();
			set => SetPropertyValue<CHandle<GenericContainer>>(value);
		}

		[Ordinal(115)] 
		[RED("alternativeInteractionString")] 
		public CString AlternativeInteractionString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ActivatorControllerPS()
		{
			DeviceName = "LocKey#42164";
			TweakDBRecord = "Devices.Activator";
			TweakDBDescriptionRecord = 127414107948;
			HasSimpleInteraction = true;
			AlternativeInteractionString = "ToggleActivate";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
