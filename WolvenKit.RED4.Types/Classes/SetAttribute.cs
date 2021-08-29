using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetAttribute : gamePlayerScriptableSystemRequest
	{
		private CFloat _statLevel;
		private CEnum<gamedataStatType> _attributeType;

		[Ordinal(1)] 
		[RED("statLevel")] 
		public CFloat StatLevel
		{
			get => GetProperty(ref _statLevel);
			set => SetProperty(ref _statLevel, value);
		}

		[Ordinal(2)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}
	}
}
