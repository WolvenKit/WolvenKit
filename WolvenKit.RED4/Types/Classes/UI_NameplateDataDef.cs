using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_NameplateDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("EntityID")] 
		public gamebbScriptID_Variant EntityID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("IsVisible")] 
		public gamebbScriptID_Bool IsVisible
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("HeightOffset")] 
		public gamebbScriptID_Float HeightOffset
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("DamageProjection")] 
		public gamebbScriptID_Int32 DamageProjection
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public UI_NameplateDataDef()
		{
			EntityID = new();
			IsVisible = new();
			HeightOffset = new();
			DamageProjection = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
