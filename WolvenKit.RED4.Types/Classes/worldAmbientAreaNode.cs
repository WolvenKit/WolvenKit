using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAmbientAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("useCustomColor")] 
		public CBool UseCustomColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
