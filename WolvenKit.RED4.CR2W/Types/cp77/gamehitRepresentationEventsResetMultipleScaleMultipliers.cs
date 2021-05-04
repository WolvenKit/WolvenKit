using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsResetMultipleScaleMultipliers : redEvent
	{
		private CArray<CName> _shapeNames;

		[Ordinal(0)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get => GetProperty(ref _shapeNames);
			set => SetProperty(ref _shapeNames, value);
		}

		public gamehitRepresentationEventsResetMultipleScaleMultipliers(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
