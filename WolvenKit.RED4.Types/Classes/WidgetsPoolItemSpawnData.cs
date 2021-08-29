using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetsPoolItemSpawnData : IScriptable
	{
		private CInt32 _index;
		private CInt32 _requestVersion;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("requestVersion")] 
		public CInt32 RequestVersion
		{
			get => GetProperty(ref _requestVersion);
			set => SetProperty(ref _requestVersion, value);
		}
	}
}
