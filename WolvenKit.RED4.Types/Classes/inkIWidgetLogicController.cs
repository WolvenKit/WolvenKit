using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkIWidgetLogicController : IScriptable
	{
		private CName _audioMetadataName;

		[Ordinal(0)] 
		[RED("audioMetadataName")] 
		public CName AudioMetadataName
		{
			get => GetProperty(ref _audioMetadataName);
			set => SetProperty(ref _audioMetadataName, value);
		}
	}
}
