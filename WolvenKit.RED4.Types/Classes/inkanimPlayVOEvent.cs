using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPlayVOEvent : inkanimEvent
	{
		private CString _vOLine;
		private CString _speakerName;

		[Ordinal(1)] 
		[RED("VOLine")] 
		public CString VOLine
		{
			get => GetProperty(ref _vOLine);
			set => SetProperty(ref _vOLine, value);
		}

		[Ordinal(2)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetProperty(ref _speakerName);
			set => SetProperty(ref _speakerName, value);
		}
	}
}
