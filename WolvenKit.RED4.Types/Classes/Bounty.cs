using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Bounty : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transgressions")] 
		public CArray<TweakDBID> Transgressions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(1)] 
		[RED("bountySetter")] 
		public TweakDBID BountySetter
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("moneyAmount")] 
		public CInt32 MoneyAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("streetCredAmount")] 
		public CInt32 StreetCredAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("awarded")] 
		public CBool Awarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("wantedStars")] 
		public CInt32 WantedStars
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Bounty()
		{
			Transgressions = new();
		}
	}
}
