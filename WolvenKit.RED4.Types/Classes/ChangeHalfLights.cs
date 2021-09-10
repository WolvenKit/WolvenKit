using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeHalfLights : redEvent
	{
		[Ordinal(0)] 
		[RED("isAuthorization")] 
		public CBool IsAuthorization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
