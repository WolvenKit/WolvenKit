using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveSign : Device
	{
		[Ordinal(88)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get => GetPropertyValue<CEnum<SignShape>>();
			set => SetPropertyValue<CEnum<SignShape>>(value);
		}

		[Ordinal(89)] 
		[RED("type")] 
		public CEnum<SignType> Type
		{
			get => GetPropertyValue<CEnum<SignType>>();
			set => SetPropertyValue<CEnum<SignType>>(value);
		}

		[Ordinal(90)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public InteractiveSign()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
