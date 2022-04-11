using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAnimationRidAudioData : ISerializable
	{
		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CHandle<animAnimEvent>> Events
		{
			get => GetPropertyValue<CArray<CHandle<animAnimEvent>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimEvent>>>(value);
		}

		public scnAnimationRidAudioData()
		{
			Events = new();
		}
	}
}
