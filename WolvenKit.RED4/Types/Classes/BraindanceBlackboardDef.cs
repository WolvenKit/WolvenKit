using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("activeBraindanceVisionMode")] 
		public gamebbScriptID_Int32 ActiveBraindanceVisionMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("lastBraindanceVisionMode")] 
		public gamebbScriptID_Int32 LastBraindanceVisionMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("SectionTime")] 
		public gamebbScriptID_Float SectionTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("Clue")] 
		public gamebbScriptID_Variant Clue
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("EnableExit")] 
		public gamebbScriptID_Bool EnableExit
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("IsFPP")] 
		public gamebbScriptID_Bool IsFPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("PlaybackSpeed")] 
		public gamebbScriptID_Variant PlaybackSpeed
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(9)] 
		[RED("PlaybackDirection")] 
		public gamebbScriptID_Variant PlaybackDirection
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public BraindanceBlackboardDef()
		{
			ActiveBraindanceVisionMode = new gamebbScriptID_Int32();
			LastBraindanceVisionMode = new gamebbScriptID_Int32();
			Progress = new gamebbScriptID_Float();
			SectionTime = new gamebbScriptID_Float();
			Clue = new gamebbScriptID_Variant();
			IsActive = new gamebbScriptID_Bool();
			EnableExit = new gamebbScriptID_Bool();
			IsFPP = new gamebbScriptID_Bool();
			PlaybackSpeed = new gamebbScriptID_Variant();
			PlaybackDirection = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
