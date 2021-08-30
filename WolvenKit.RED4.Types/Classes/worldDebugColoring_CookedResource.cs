using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_CookedResource : worldEditorDebugColoringSettings
	{
		private CUInt8 _alpha;

		[Ordinal(0)] 
		[RED("alpha")] 
		public CUInt8 Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		public worldDebugColoring_CookedResource()
		{
			_alpha = 192;
		}
	}
}
