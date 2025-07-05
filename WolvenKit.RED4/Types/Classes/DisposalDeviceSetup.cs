using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisposalDeviceSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numberOfUses")] 
		public CInt32 NumberOfUses
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isBodyRequired")] 
		public CBool IsBodyRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("actionName")] 
		public TweakDBID ActionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("takedownActionName")] 
		public TweakDBID TakedownActionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("nonlethalTakedownActionName")] 
		public TweakDBID NonlethalTakedownActionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public DisposalDeviceSetup()
		{
			NumberOfUses = 1;
			IsBodyRequired = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
