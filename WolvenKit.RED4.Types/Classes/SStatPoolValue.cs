using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SStatPoolValue : RedBaseClass
	{
		private CEnum<gamedataStatPoolType> _type;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatPoolType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
