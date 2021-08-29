using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveSign : Device
	{
		private CEnum<SignShape> _signShape;
		private CEnum<SignType> _type;
		private CString _message;

		[Ordinal(87)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get => GetProperty(ref _signShape);
			set => SetProperty(ref _signShape, value);
		}

		[Ordinal(88)] 
		[RED("type")] 
		public CEnum<SignType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(89)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}
	}
}
