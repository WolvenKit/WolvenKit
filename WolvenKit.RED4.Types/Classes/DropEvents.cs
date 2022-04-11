using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropEvents : CarriedObjectEvents
	{
		[Ordinal(9)] 
		[RED("ragdollReenabled")] 
		public CBool RagdollReenabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DropEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";
		}
	}
}
