using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDeviceMappinData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mappinName")] 
		public CName MappinName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("mappinVariant")] 
		public CEnum<gamedataMappinVariant> MappinVariant
		{
			get => GetPropertyValue<CEnum<gamedataMappinVariant>>();
			set => SetPropertyValue<CEnum<gamedataMappinVariant>>(value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("checkIfIsTarget")] 
		public CBool CheckIfIsTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("id")] 
		public gameNewMappinID Id
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(11)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		[Ordinal(13)] 
		[RED("visualStateData")] 
		public CHandle<GameplayRoleMappinData> VisualStateData
		{
			get => GetPropertyValue<CHandle<GameplayRoleMappinData>>();
			set => SetPropertyValue<CHandle<GameplayRoleMappinData>>(value);
		}

		public SDeviceMappinData()
		{
			Enabled = true;
			Range = 30.000000F;
			Offset = new Vector4();
			Position = new Vector4();
			CheckIfIsTarget = true;
			Id = new gameNewMappinID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
