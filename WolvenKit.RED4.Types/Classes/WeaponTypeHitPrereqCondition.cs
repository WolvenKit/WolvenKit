using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _type;

		[Ordinal(1)] 
		[RED("type")] 
		public CName Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
