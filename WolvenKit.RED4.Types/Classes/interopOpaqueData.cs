using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopOpaqueData : RedBaseClass
	{
		private CString _description;
		private CString _payload;
		private CInt32 _version;

		[Ordinal(0)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(1)] 
		[RED("payload")] 
		public CString Payload
		{
			get => GetProperty(ref _payload);
			set => SetProperty(ref _payload, value);
		}

		[Ordinal(2)] 
		[RED("version")] 
		public CInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}
	}
}
