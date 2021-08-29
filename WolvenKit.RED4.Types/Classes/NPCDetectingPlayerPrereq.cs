using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCDetectingPlayerPrereq : gameIScriptablePrereq
	{
		private CFloat _threshold;

		[Ordinal(0)] 
		[RED("threshold")] 
		public CFloat Threshold
		{
			get => GetProperty(ref _threshold);
			set => SetProperty(ref _threshold, value);
		}
	}
}
