using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBooleanArgumentWhenActive : AIbehaviortaskScript
	{
		private CName _booleanArgument;

		[Ordinal(0)] 
		[RED("booleanArgument")] 
		public CName BooleanArgument
		{
			get => GetProperty(ref _booleanArgument);
			set => SetProperty(ref _booleanArgument, value);
		}
	}
}
