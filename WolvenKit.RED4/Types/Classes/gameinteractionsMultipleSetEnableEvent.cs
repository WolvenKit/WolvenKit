using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsMultipleSetEnableEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("enable", 4)] 
		public CStatic<CBool> Enable
		{
			get => GetPropertyValue<CStatic<CBool>>();
			set => SetPropertyValue<CStatic<CBool>>(value);
		}

		[Ordinal(1)] 
		[RED("layer", 4)] 
		public CStatic<CName> Layer
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("linkedLayers", 4)] 
		public CStatic<CName> LinkedLayers
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		public gameinteractionsMultipleSetEnableEvent()
		{
			Enable = new(0);
			Layer = new(0);
			LinkedLayers = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
