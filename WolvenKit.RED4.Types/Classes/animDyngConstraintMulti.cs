using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDyngConstraintMulti : animIDyngConstraint
	{
		[Ordinal(1)] 
		[RED("innerConstraints")] 
		public CArray<CHandle<animIDyngConstraint>> InnerConstraints
		{
			get => GetPropertyValue<CArray<CHandle<animIDyngConstraint>>>();
			set => SetPropertyValue<CArray<CHandle<animIDyngConstraint>>>(value);
		}

		public animDyngConstraintMulti()
		{
			InnerConstraints = new();
		}
	}
}
