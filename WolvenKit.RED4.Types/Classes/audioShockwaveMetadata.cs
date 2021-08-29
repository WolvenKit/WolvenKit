using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioShockwaveMetadata : audioEmitterMetadata
	{
		private CName _explosionMetadataName;
		private CName _thumpMetadataName;
		private CName _electroshockMetadataName;
		private CName _revealMetadataName;

		[Ordinal(1)] 
		[RED("explosionMetadataName")] 
		public CName ExplosionMetadataName
		{
			get => GetProperty(ref _explosionMetadataName);
			set => SetProperty(ref _explosionMetadataName, value);
		}

		[Ordinal(2)] 
		[RED("thumpMetadataName")] 
		public CName ThumpMetadataName
		{
			get => GetProperty(ref _thumpMetadataName);
			set => SetProperty(ref _thumpMetadataName, value);
		}

		[Ordinal(3)] 
		[RED("electroshockMetadataName")] 
		public CName ElectroshockMetadataName
		{
			get => GetProperty(ref _electroshockMetadataName);
			set => SetProperty(ref _electroshockMetadataName, value);
		}

		[Ordinal(4)] 
		[RED("revealMetadataName")] 
		public CName RevealMetadataName
		{
			get => GetProperty(ref _revealMetadataName);
			set => SetProperty(ref _revealMetadataName, value);
		}
	}
}
