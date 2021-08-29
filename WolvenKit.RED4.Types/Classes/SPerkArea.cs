using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SPerkArea : RedBaseClass
	{
		private CEnum<gamedataPerkArea> _type;
		private CBool _unlocked;
		private CArray<SPerk> _boughtPerks;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkArea> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}

		[Ordinal(2)] 
		[RED("boughtPerks")] 
		public CArray<SPerk> BoughtPerks
		{
			get => GetProperty(ref _boughtPerks);
			set => SetProperty(ref _boughtPerks, value);
		}
	}
}
