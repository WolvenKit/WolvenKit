using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_DatabaseRow : CVariable
	{
		private CName _animFeatureName;
		private CInt32 _state;
		private CInt32 _animVariation;
		private animActionAnimDatabase_AnimationData _animationData;

		[Ordinal(0)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(3)] 
		[RED("animationData")] 
		public animActionAnimDatabase_AnimationData AnimationData
		{
			get => GetProperty(ref _animationData);
			set => SetProperty(ref _animationData, value);
		}

		public animActionAnimDatabase_DatabaseRow(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
