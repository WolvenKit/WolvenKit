using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassembleOptions : RedBaseClass
	{
		private CBool _canBeDisassembled;

		[Ordinal(0)] 
		[RED("canBeDisassembled")] 
		public CBool CanBeDisassembled
		{
			get => GetProperty(ref _canBeDisassembled);
			set => SetProperty(ref _canBeDisassembled, value);
		}
	}
}
