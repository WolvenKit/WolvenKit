using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class localizationPersistenceCLNumberDateContainer : ISerializable
	{
		private CName _clNumber;
		private CName _clTimestamp;

		[Ordinal(0)] 
		[RED("clNumber")] 
		public CName ClNumber
		{
			get => GetProperty(ref _clNumber);
			set => SetProperty(ref _clNumber, value);
		}

		[Ordinal(1)] 
		[RED("clTimestamp")] 
		public CName ClTimestamp
		{
			get => GetProperty(ref _clTimestamp);
			set => SetProperty(ref _clTimestamp, value);
		}
	}
}
