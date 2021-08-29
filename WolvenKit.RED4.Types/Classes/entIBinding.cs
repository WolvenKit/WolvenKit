using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entIBinding : ISerializable
	{
		private CBool _enabled;
		private entTagMask _enableMask;
		private CName _bindName;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("enableMask")] 
		public entTagMask EnableMask
		{
			get => GetProperty(ref _enableMask);
			set => SetProperty(ref _enableMask, value);
		}

		[Ordinal(2)] 
		[RED("bindName")] 
		public CName BindName
		{
			get => GetProperty(ref _bindName);
			set => SetProperty(ref _bindName, value);
		}
	}
}
