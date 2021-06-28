using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		private CName _shapeName;

		[Ordinal(1)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get => GetProperty(ref _shapeName);
			set => SetProperty(ref _shapeName, value);
		}

		public gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
