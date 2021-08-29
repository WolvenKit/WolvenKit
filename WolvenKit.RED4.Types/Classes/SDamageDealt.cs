using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDamageDealt : RedBaseClass
	{
		private CEnum<gamedataDamageType> _type;
		private CFloat _value;
		private CEnum<gamedataStatPoolType> _affectedStatPool;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDamageType> Type
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

		[Ordinal(2)] 
		[RED("affectedStatPool")] 
		public CEnum<gamedataStatPoolType> AffectedStatPool
		{
			get => GetProperty(ref _affectedStatPool);
			set => SetProperty(ref _affectedStatPool, value);
		}
	}
}
