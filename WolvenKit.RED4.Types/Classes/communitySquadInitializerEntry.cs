using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communitySquadInitializerEntry : RedBaseClass
	{
		private CEnum<communityESquadType> _type;
		private CName _value;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<communityESquadType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CName Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public communitySquadInitializerEntry()
		{
			_type = new() { Value = Enums.communityESquadType.Unknown };
		}
	}
}
