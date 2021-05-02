using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothState : CVariable
	{
		private physicsclothPhaseConfig _verticalPhaseData;
		private physicsclothPhaseConfig _horizontalPhaseData;
		private physicsclothPhaseConfig _bendPhaseData;
		private physicsclothPhaseConfig _shearPhaseData;
		private physicsclothRuntimeInfo _runtimeInfo;

		[Ordinal(0)] 
		[RED("verticalPhaseData")] 
		public physicsclothPhaseConfig VerticalPhaseData
		{
			get => GetProperty(ref _verticalPhaseData);
			set => SetProperty(ref _verticalPhaseData, value);
		}

		[Ordinal(1)] 
		[RED("horizontalPhaseData")] 
		public physicsclothPhaseConfig HorizontalPhaseData
		{
			get => GetProperty(ref _horizontalPhaseData);
			set => SetProperty(ref _horizontalPhaseData, value);
		}

		[Ordinal(2)] 
		[RED("bendPhaseData")] 
		public physicsclothPhaseConfig BendPhaseData
		{
			get => GetProperty(ref _bendPhaseData);
			set => SetProperty(ref _bendPhaseData, value);
		}

		[Ordinal(3)] 
		[RED("shearPhaseData")] 
		public physicsclothPhaseConfig ShearPhaseData
		{
			get => GetProperty(ref _shearPhaseData);
			set => SetProperty(ref _shearPhaseData, value);
		}

		[Ordinal(4)] 
		[RED("runtimeInfo")] 
		public physicsclothRuntimeInfo RuntimeInfo
		{
			get => GetProperty(ref _runtimeInfo);
			set => SetProperty(ref _runtimeInfo, value);
		}

		public physicsclothState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
