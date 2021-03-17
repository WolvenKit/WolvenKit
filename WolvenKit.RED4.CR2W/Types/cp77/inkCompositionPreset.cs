using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreset : CVariable
	{
		private CName _stateName;
		private CBool _useBackgroundTexture;
		private fxCompositionShaderParams _shaderParams;
		private CArray<inkCompositionTransition> _transitions;

		[Ordinal(0)] 
		[RED("stateName")] 
		public CName StateName
		{
			get => GetProperty(ref _stateName);
			set => SetProperty(ref _stateName, value);
		}

		[Ordinal(1)] 
		[RED("useBackgroundTexture")] 
		public CBool UseBackgroundTexture
		{
			get => GetProperty(ref _useBackgroundTexture);
			set => SetProperty(ref _useBackgroundTexture, value);
		}

		[Ordinal(2)] 
		[RED("shaderParams")] 
		public fxCompositionShaderParams ShaderParams
		{
			get => GetProperty(ref _shaderParams);
			set => SetProperty(ref _shaderParams, value);
		}

		[Ordinal(3)] 
		[RED("transitions")] 
		public CArray<inkCompositionTransition> Transitions
		{
			get => GetProperty(ref _transitions);
			set => SetProperty(ref _transitions, value);
		}

		public inkCompositionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
