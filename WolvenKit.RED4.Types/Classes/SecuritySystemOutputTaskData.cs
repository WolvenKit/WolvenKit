using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemOutputTaskData : gameScriptTaskData
	{
		private CHandle<SecuritySystemOutput> _cachedEvt;

		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<SecuritySystemOutput> CachedEvt
		{
			get => GetProperty(ref _cachedEvt);
			set => SetProperty(ref _cachedEvt, value);
		}
	}
}
