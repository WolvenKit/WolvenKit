using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class redErrorResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CVariant UserData
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public redErrorResult()
		{
			Message = "Unknown error";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
