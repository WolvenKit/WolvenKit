using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questReactionPresetRecordSelector : ISerializable
	{
		[Ordinal(0)] 
		[RED("setDefault")] 
		public CBool SetDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("gangerRecordID")] 
		public TweakDBID GangerRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("civilianRecordID")] 
		public TweakDBID CivilianRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("isCorpo")] 
		public CBool IsCorpo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("corpoRecordID")] 
		public TweakDBID CorpoRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(7)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("policeRecordID")] 
		public TweakDBID PoliceRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("isMechanical")] 
		public CBool IsMechanical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("mechanicalRecordID")] 
		public TweakDBID MechanicalRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("isNoReaction")] 
		public CBool IsNoReaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("noReactionRecordID")] 
		public TweakDBID NoReactionRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questReactionPresetRecordSelector()
		{
			IsGanger = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
