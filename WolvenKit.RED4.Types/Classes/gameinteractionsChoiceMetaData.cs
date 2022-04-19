using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceMetaData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tweakDBName")] 
		public CString TweakDBName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetPropertyValue<gameinteractionsChoiceTypeWrapper>();
			set => SetPropertyValue<gameinteractionsChoiceTypeWrapper>(value);
		}

		public gameinteractionsChoiceMetaData()
		{
			Type = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
