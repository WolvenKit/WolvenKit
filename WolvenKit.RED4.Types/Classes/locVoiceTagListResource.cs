using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoiceTagListResource : CResource
	{
		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<locVoiceTag> VoiceTags
		{
			get => GetPropertyValue<CArray<locVoiceTag>>();
			set => SetPropertyValue<CArray<locVoiceTag>>(value);
		}

		public locVoiceTagListResource()
		{
			VoiceTags = new();
		}
	}
}
