using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DetectionMeterEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("detectionStep")] 
		public CFloat DetectionStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maxStacks")] 
		public CInt32 MaxStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("onlyHostileDetection")] 
		public CBool OnlyHostileDetection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("dontRemoveStacks")] 
		public CBool DontRemoveStacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("detectionListener")] 
		public CHandle<redCallbackObject> DetectionListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("currentStacks")] 
		public CInt32 CurrentStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(8)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public DetectionMeterEffector()
		{
			GameInstance = new ScriptGameInstance();
			OwnerID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
