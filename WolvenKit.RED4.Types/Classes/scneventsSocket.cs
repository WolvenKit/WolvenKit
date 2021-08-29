using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsSocket : scnSceneEvent
	{
		private scnOutputSocketStamp _osockStamp;

		[Ordinal(6)] 
		[RED("osockStamp")] 
		public scnOutputSocketStamp OsockStamp
		{
			get => GetProperty(ref _osockStamp);
			set => SetProperty(ref _osockStamp, value);
		}
	}
}
