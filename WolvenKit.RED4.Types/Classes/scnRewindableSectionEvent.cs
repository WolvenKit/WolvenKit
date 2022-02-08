using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRewindableSectionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
