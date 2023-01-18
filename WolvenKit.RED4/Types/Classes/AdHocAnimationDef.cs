using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AdHocAnimationDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("AnimationIndex")] 
		public gamebbScriptID_Int32 AnimationIndex
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("UseBothHands")] 
		public gamebbScriptID_Bool UseBothHands
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("UnequipWeapon")] 
		public gamebbScriptID_Bool UnequipWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public AdHocAnimationDef()
		{
			IsActive = new();
			AnimationIndex = new();
			UseBothHands = new();
			UnequipWeapon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
