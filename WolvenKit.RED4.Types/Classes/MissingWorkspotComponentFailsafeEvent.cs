using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MissingWorkspotComponentFailsafeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public MissingWorkspotComponentFailsafeEvent()
		{
			PlayerEntityID = new();
		}
	}
}
