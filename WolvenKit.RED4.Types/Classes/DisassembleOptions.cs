using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassembleOptions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("canBeDisassembled")] 
		public CBool CanBeDisassembled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
