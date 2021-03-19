using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRaceSplineNode : worldSpeedSplineNode
	{
		private CArray<worldRaceSplineNodeOffset> _offsets;
		private CFloat _offsetDefault;

		[Ordinal(17)] 
		[RED("offsets")] 
		public CArray<worldRaceSplineNodeOffset> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		[Ordinal(18)] 
		[RED("offsetDefault")] 
		public CFloat OffsetDefault
		{
			get => GetProperty(ref _offsetDefault);
			set => SetProperty(ref _offsetDefault, value);
		}

		public worldRaceSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
