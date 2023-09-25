using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CentaurShieldController : AICustomComponents
	{
		[Ordinal(5)] 
		[RED("startWithShieldActive")] 
		public CBool StartWithShieldActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("shieldDestroyedModifierName")] 
		public CName ShieldDestroyedModifierName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("shieldState")] 
		public CEnum<ECentaurShieldState> ShieldState
		{
			get => GetPropertyValue<CEnum<ECentaurShieldState>>();
			set => SetPropertyValue<CEnum<ECentaurShieldState>>(value);
		}

		[Ordinal(9)] 
		[RED("centaurBlackboard")] 
		public CHandle<gameIBlackboard> CentaurBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		public CentaurShieldController()
		{
			StartWithShieldActive = true;
			AnimFeatureName = "ShieldState";
			ShieldDestroyedModifierName = "Shield_ControllerDestroyed";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
