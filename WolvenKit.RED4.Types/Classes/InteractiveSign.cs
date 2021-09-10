using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveSign : Device
	{
		[Ordinal(87)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get => GetPropertyValue<CEnum<SignShape>>();
			set => SetPropertyValue<CEnum<SignShape>>(value);
		}

		[Ordinal(88)] 
		[RED("type")] 
		public CEnum<SignType> Type
		{
			get => GetPropertyValue<CEnum<SignType>>();
			set => SetPropertyValue<CEnum<SignType>>(value);
		}

		[Ordinal(89)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public InteractiveSign()
		{
			ControllerTypeName = "InteractiveSignController";
		}
	}
}
