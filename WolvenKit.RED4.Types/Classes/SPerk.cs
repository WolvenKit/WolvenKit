using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SPerk : RedBaseClass
	{
		private CEnum<gamedataPerkType> _type;
		private CInt32 _currLevel;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("currLevel")] 
		public CInt32 CurrLevel
		{
			get => GetProperty(ref _currLevel);
			set => SetProperty(ref _currLevel, value);
		}
	}
}
