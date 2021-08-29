using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkServerInfo : IScriptable
	{
		private CInt32 _number;
		private CString _kind;
		private CString _hostname;
		private CString _address;
		private CString _worldDescription;

		[Ordinal(0)] 
		[RED("number")] 
		public CInt32 Number
		{
			get => GetProperty(ref _number);
			set => SetProperty(ref _number, value);
		}

		[Ordinal(1)] 
		[RED("kind")] 
		public CString Kind
		{
			get => GetProperty(ref _kind);
			set => SetProperty(ref _kind, value);
		}

		[Ordinal(2)] 
		[RED("hostname")] 
		public CString Hostname
		{
			get => GetProperty(ref _hostname);
			set => SetProperty(ref _hostname, value);
		}

		[Ordinal(3)] 
		[RED("address")] 
		public CString Address
		{
			get => GetProperty(ref _address);
			set => SetProperty(ref _address, value);
		}

		[Ordinal(4)] 
		[RED("worldDescription")] 
		public CString WorldDescription
		{
			get => GetProperty(ref _worldDescription);
			set => SetProperty(ref _worldDescription, value);
		}
	}
}
