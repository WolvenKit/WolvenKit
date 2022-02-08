using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeStanceStateAbstract : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("changeStateOnDeactivate")] 
		public CBool ChangeStateOnDeactivate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
