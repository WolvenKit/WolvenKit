using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDyngConstraintMulti : animIDyngConstraint
	{
		private CArray<CHandle<animIDyngConstraint>> _innerConstraints;

		[Ordinal(1)] 
		[RED("innerConstraints")] 
		public CArray<CHandle<animIDyngConstraint>> InnerConstraints
		{
			get => GetProperty(ref _innerConstraints);
			set => SetProperty(ref _innerConstraints, value);
		}
	}
}
