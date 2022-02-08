using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemOutputTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<SecuritySystemOutput> CachedEvt
		{
			get => GetPropertyValue<CHandle<SecuritySystemOutput>>();
			set => SetPropertyValue<CHandle<SecuritySystemOutput>>(value);
		}
	}
}
