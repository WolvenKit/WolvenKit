using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioMixNodeType : questIAudioNodeType
	{
		private CName _mixSignpost;

		[Ordinal(0)] 
		[RED("mixSignpost")] 
		public CName MixSignpost
		{
			get => GetProperty(ref _mixSignpost);
			set => SetProperty(ref _mixSignpost, value);
		}
	}
}
