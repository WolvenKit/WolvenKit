using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceContextMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceContextMapItem> _contexts;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetProperty(ref _includes);
			set => SetProperty(ref _includes, value);
		}

		[Ordinal(2)] 
		[RED("contexts")] 
		public CArray<audioVoiceContextMapItem> Contexts
		{
			get => GetProperty(ref _contexts);
			set => SetProperty(ref _contexts, value);
		}
	}
}
