using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SHitFlag : RedBaseClass
	{
		private CEnum<hitFlag> _flag;
		private CName _source;

		[Ordinal(0)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get => GetProperty(ref _flag);
			set => SetProperty(ref _flag, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}
	}
}
