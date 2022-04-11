using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObjectInspectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
