using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioMixNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("mixSignpost")] 
		public CName MixSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
