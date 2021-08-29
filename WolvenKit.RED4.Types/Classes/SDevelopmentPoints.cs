using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDevelopmentPoints : RedBaseClass
	{
		private CEnum<gamedataDevelopmentPointType> _type;
		private CInt32 _spent;
		private CInt32 _unspent;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("spent")] 
		public CInt32 Spent
		{
			get => GetProperty(ref _spent);
			set => SetProperty(ref _spent, value);
		}

		[Ordinal(2)] 
		[RED("unspent")] 
		public CInt32 Unspent
		{
			get => GetProperty(ref _unspent);
			set => SetProperty(ref _unspent, value);
		}
	}
}
