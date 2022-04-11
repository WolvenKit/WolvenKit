using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveEnteredSplineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("useDoors")] 
		public CBool UseDoors
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
