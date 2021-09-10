using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TV : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get => GetPropertyValue<CArray<STvChannel>>();
			set => SetPropertyValue<CArray<STvChannel>>(value);
		}

		[Ordinal(98)] 
		[RED("initialActiveChannel")] 
		public CInt32 InitialActiveChannel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(99)] 
		[RED("securedText")] 
		public CString SecuredText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(100)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
		[RED("useWhiteNoiseFX")] 
		public CBool UseWhiteNoiseFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(103)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(105)] 
		[RED("isTVMoving")] 
		public CBool IsTVMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TV()
		{
			ControllerTypeName = "TVController";
			Channels = new();
			SecuredText = "SECURED";
			MuteInterface = true;
			ShortGlitchDelayID = new();
		}
	}
}
