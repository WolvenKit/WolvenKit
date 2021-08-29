using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_WorkspotPlayFacialAnim : animAnimEvent
	{
		private CName _facialAnimName;

		[Ordinal(3)] 
		[RED("facialAnimName")] 
		public CName FacialAnimName
		{
			get => GetProperty(ref _facialAnimName);
			set => SetProperty(ref _facialAnimName, value);
		}
	}
}
