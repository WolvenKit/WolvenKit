using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAmbientAreaNode : worldTriggerAreaNode
	{
		private CBool _useCustomColor;

		[Ordinal(7)] 
		[RED("useCustomColor")] 
		public CBool UseCustomColor
		{
			get => GetProperty(ref _useCustomColor);
			set => SetProperty(ref _useCustomColor, value);
		}
	}
}
