using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsStopTaggedSounds : redEvent
	{
		private CName _audioTag;

		[Ordinal(0)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetProperty(ref _audioTag);
			set => SetProperty(ref _audioTag, value);
		}
	}
}
