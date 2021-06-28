using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerAdvancedUserInput : CVariable
	{
		private CStatic<animCurvePathPartInput> _partsInputs;

		[Ordinal(0)] 
		[RED("partsInputs", 3)] 
		public CStatic<animCurvePathPartInput> PartsInputs
		{
			get => GetProperty(ref _partsInputs);
			set => SetProperty(ref _partsInputs, value);
		}

		public animCurvePathBakerAdvancedUserInput(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
