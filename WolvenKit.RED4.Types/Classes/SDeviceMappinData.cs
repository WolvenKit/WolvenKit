using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDeviceMappinData : RedBaseClass
	{
		private CName _mappinName;
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinVariant> _mappinVariant;
		private CBool _enabled;
		private CFloat _range;
		private CString _caption;
		private Vector4 _offset;
		private Vector4 _position;
		private CBool _permanent;
		private CBool _checkIfIsTarget;
		private gameNewMappinID _id;
		private CBool _active;
		private CEnum<EGameplayRole> _gameplayRole;
		private CHandle<GameplayRoleMappinData> _visualStateData;

		[Ordinal(0)] 
		[RED("mappinName")] 
		public CName MappinName
		{
			get => GetProperty(ref _mappinName);
			set => SetProperty(ref _mappinName, value);
		}

		[Ordinal(1)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetProperty(ref _mappinType);
			set => SetProperty(ref _mappinType, value);
		}

		[Ordinal(2)] 
		[RED("mappinVariant")] 
		public CEnum<gamedataMappinVariant> MappinVariant
		{
			get => GetProperty(ref _mappinVariant);
			set => SetProperty(ref _mappinVariant, value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(4)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(5)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetProperty(ref _caption);
			set => SetProperty(ref _caption, value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(7)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(8)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetProperty(ref _permanent);
			set => SetProperty(ref _permanent, value);
		}

		[Ordinal(9)] 
		[RED("checkIfIsTarget")] 
		public CBool CheckIfIsTarget
		{
			get => GetProperty(ref _checkIfIsTarget);
			set => SetProperty(ref _checkIfIsTarget, value);
		}

		[Ordinal(10)] 
		[RED("id")] 
		public gameNewMappinID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(11)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(12)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetProperty(ref _gameplayRole);
			set => SetProperty(ref _gameplayRole, value);
		}

		[Ordinal(13)] 
		[RED("visualStateData")] 
		public CHandle<GameplayRoleMappinData> VisualStateData
		{
			get => GetProperty(ref _visualStateData);
			set => SetProperty(ref _visualStateData, value);
		}

		public SDeviceMappinData()
		{
			_enabled = true;
			_range = 30.000000F;
			_checkIfIsTarget = true;
		}
	}
}
