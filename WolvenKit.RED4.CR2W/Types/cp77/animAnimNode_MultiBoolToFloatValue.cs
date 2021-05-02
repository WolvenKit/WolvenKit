using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultiBoolToFloatValue : animAnimNode_FloatValue
	{
		private CBool _allMustBeTrue;
		private CFloat _onTrue;
		private CFloat _onFalse;
		private CArray<animAnimMultiBoolToFloatEntry> _inputsData;

		[Ordinal(11)] 
		[RED("allMustBeTrue")] 
		public CBool AllMustBeTrue
		{
			get => GetProperty(ref _allMustBeTrue);
			set => SetProperty(ref _allMustBeTrue, value);
		}

		[Ordinal(12)] 
		[RED("onTrue")] 
		public CFloat OnTrue
		{
			get => GetProperty(ref _onTrue);
			set => SetProperty(ref _onTrue, value);
		}

		[Ordinal(13)] 
		[RED("onFalse")] 
		public CFloat OnFalse
		{
			get => GetProperty(ref _onFalse);
			set => SetProperty(ref _onFalse, value);
		}

		[Ordinal(14)] 
		[RED("inputsData")] 
		public CArray<animAnimMultiBoolToFloatEntry> InputsData
		{
			get => GetProperty(ref _inputsData);
			set => SetProperty(ref _inputsData, value);
		}

		public animAnimNode_MultiBoolToFloatValue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
