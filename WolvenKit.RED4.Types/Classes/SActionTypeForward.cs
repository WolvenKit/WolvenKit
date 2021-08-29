using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SActionTypeForward : RedBaseClass
	{
		private CBool _qHack;
		private CBool _techie;
		private CBool _master;

		[Ordinal(0)] 
		[RED("qHack")] 
		public CBool QHack
		{
			get => GetProperty(ref _qHack);
			set => SetProperty(ref _qHack, value);
		}

		[Ordinal(1)] 
		[RED("techie")] 
		public CBool Techie
		{
			get => GetProperty(ref _techie);
			set => SetProperty(ref _techie, value);
		}

		[Ordinal(2)] 
		[RED("master")] 
		public CBool Master
		{
			get => GetProperty(ref _master);
			set => SetProperty(ref _master, value);
		}
	}
}
