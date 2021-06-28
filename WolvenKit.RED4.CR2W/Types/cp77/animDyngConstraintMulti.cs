using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintMulti : animIDyngConstraint
	{
		private CArray<CHandle<animIDyngConstraint>> _innerConstraints;

		[Ordinal(1)] 
		[RED("innerConstraints")] 
		public CArray<CHandle<animIDyngConstraint>> InnerConstraints
		{
			get => GetProperty(ref _innerConstraints);
			set => SetProperty(ref _innerConstraints, value);
		}

		public animDyngConstraintMulti(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
