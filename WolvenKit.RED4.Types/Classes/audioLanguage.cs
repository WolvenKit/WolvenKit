using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLanguage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("longName")] 
		public CString LongName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("codeName")] 
		public CString CodeName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("hasVO")] 
		public CBool HasVO
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioLanguage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
