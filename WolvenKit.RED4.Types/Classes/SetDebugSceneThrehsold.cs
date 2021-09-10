using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetDebugSceneThrehsold : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("newThreshold")] 
		public CInt32 NewThreshold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
