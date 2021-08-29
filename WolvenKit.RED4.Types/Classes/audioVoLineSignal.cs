using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoLineSignal : RedBaseClass
	{
		private CRUID _ruid;
		private CName _signal;

		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetProperty(ref _ruid);
			set => SetProperty(ref _ruid, value);
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get => GetProperty(ref _signal);
			set => SetProperty(ref _signal, value);
		}
	}
}
