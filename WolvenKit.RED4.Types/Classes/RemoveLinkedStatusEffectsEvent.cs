using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveLinkedStatusEffectsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
