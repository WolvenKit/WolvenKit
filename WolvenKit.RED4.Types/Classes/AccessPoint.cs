using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AccessPoint : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(95)] 
		[RED("isPlayerInBreachView")] 
		public CBool IsPlayerInBreachView
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("breachViewTimeListener")] 
		public CHandle<BreachViewTimeListener> BreachViewTimeListener
		{
			get => GetPropertyValue<CHandle<BreachViewTimeListener>>();
			set => SetPropertyValue<CHandle<BreachViewTimeListener>>(value);
		}

		[Ordinal(98)] 
		[RED("upload_program_listener_id")] 
		public CUInt32 Upload_program_listener_id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public AccessPoint()
		{
			ControllerTypeName = "AccessPointController";
			NetworkName = "Local Network 1";
		}
	}
}
