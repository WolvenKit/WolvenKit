using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTRavelSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("DestinationPoint")] 
		public gamebbScriptID_Variant DestinationPoint
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("StartingPoint")] 
		public gamebbScriptID_Variant StartingPoint
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("FastTravelLoadingScreenFinished")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenFinished
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public FastTRavelSystemDef()
		{
			DestinationPoint = new();
			StartingPoint = new();
			FastTravelLoadingScreenFinished = new();
		}
	}
}
