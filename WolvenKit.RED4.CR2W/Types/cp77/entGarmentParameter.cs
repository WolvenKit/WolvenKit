using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameter : entEntityParameter
	{
		private CArray<entGarmentParameterComponentData> _componentsData;
		private garmentCollarAreaParams _collarArea;
		private CDateTime _lastUpdateDateTime;

		[Ordinal(0)] 
		[RED("componentsData")] 
		public CArray<entGarmentParameterComponentData> ComponentsData
		{
			get => GetProperty(ref _componentsData);
			set => SetProperty(ref _componentsData, value);
		}

		[Ordinal(1)] 
		[RED("collarArea")] 
		public garmentCollarAreaParams CollarArea
		{
			get => GetProperty(ref _collarArea);
			set => SetProperty(ref _collarArea, value);
		}

		[Ordinal(2)] 
		[RED("lastUpdateDateTime")] 
		public CDateTime LastUpdateDateTime
		{
			get => GetProperty(ref _lastUpdateDateTime);
			set => SetProperty(ref _lastUpdateDateTime, value);
		}

		public entGarmentParameter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
