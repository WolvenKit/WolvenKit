using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetAbility : RedBaseClass
	{
		private CInt32 _value;
		private CInt32 _blocks;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("blocks")] 
		public CInt32 Blocks
		{
			get => GetProperty(ref _blocks);
			set => SetProperty(ref _blocks, value);
		}
	}
}
