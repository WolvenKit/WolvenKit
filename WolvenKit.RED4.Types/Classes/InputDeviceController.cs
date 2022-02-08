using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputDeviceController : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
