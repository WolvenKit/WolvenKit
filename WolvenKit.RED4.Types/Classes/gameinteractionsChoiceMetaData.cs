using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceMetaData : RedBaseClass
	{
		private CString _tweakDBName;
		private TweakDBID _tweakDBID;
		private gameinteractionsChoiceTypeWrapper _type;

		[Ordinal(0)] 
		[RED("tweakDBName")] 
		public CString TweakDBName
		{
			get => GetProperty(ref _tweakDBName);
			set => SetProperty(ref _tweakDBName, value);
		}

		[Ordinal(1)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get => GetProperty(ref _tweakDBID);
			set => SetProperty(ref _tweakDBID, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
