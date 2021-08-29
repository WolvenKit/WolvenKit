using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitFlagPrereq : GenericHitPrereq
	{
		private CEnum<hitFlag> _flag;

		[Ordinal(5)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get => GetProperty(ref _flag);
			set => SetProperty(ref _flag, value);
		}
	}
}
