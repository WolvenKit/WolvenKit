using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterTrafficRunner : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
