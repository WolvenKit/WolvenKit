using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDeviceAttitude : ActionBool
	{
		[Ordinal(38)] 
		[RED("Repeat")] 
		public CBool Repeat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("IgnoreHostiles")] 
		public CBool IgnoreHostiles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("Attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		public SetDeviceAttitude()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
