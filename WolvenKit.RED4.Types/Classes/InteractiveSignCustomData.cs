using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveSignCustomData : WidgetCustomData
	{
		[Ordinal(0)] 
		[RED("messege")] 
		public CString Messege
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get => GetPropertyValue<CEnum<SignShape>>();
			set => SetPropertyValue<CEnum<SignShape>>(value);
		}

		public InteractiveSignCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
