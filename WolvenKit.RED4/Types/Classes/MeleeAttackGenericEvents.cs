using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class MeleeAttackGenericEvents : MeleeEventsTransition
	{
		[Ordinal(2)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(3)] 
		[RED("attackCreated")] 
		public CBool AttackCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("blockImpulseCreation")] 
		public CBool BlockImpulseCreation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("standUpSend")] 
		public CBool StandUpSend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("trailCreated")] 
		public CBool TrailCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("finisherTarget")] 
		public CWeakHandle<ScriptedPuppet> FinisherTarget
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(8)] 
		[RED("finisherCameraRotReseted")] 
		public CBool FinisherCameraRotReseted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("textLayer")] 
		public CUInt32 TextLayer
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("shouldBlockImpulseUpdate")] 
		public CBool ShouldBlockImpulseUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("enteredFromMeleeLeap")] 
		public CBool EnteredFromMeleeLeap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("effectPositionUpdated")] 
		public CBool EffectPositionUpdated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("tppYawOverride")] 
		public CFloat TppYawOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MeleeAttackGenericEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
