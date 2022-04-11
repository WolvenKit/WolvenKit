using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EmptyHandsDecisions : UpperBodyTransition
	{
		[Ordinal(0)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
