using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ParamData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CString Type
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ParamData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
