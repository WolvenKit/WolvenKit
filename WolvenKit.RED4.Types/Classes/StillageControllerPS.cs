using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StillageControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isCleared")] 
		public CBool IsCleared
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
