using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_QueryBox : gameEffectObjectProvider
	{
		private CHandle<physicsFilterData> _filterData;
		private gameEffectInputParameter_Vector _inputPosition;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1)] 
		[RED("inputPosition")] 
		public gameEffectInputParameter_Vector InputPosition
		{
			get => GetProperty(ref _inputPosition);
			set => SetProperty(ref _inputPosition, value);
		}

		public gameEffectObjectProvider_QueryBox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
