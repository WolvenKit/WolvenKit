using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChatter : RedBaseClass
	{
		private CUInt16 _id;
		private CWeakHandle<scnVoicesetComponent> _voicesetComponent;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("voicesetComponent")] 
		public CWeakHandle<scnVoicesetComponent> VoicesetComponent
		{
			get => GetProperty(ref _voicesetComponent);
			set => SetProperty(ref _voicesetComponent, value);
		}

		public scnChatter()
		{
			_id = 65535;
		}
	}
}
