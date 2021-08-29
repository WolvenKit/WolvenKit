using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entIAttachment : ISerializable
	{
		private CWeakHandle<entIComponent> _source;
		private CWeakHandle<entIComponent> _destination;

		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<entIComponent> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public CWeakHandle<entIComponent> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}
	}
}
