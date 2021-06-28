using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioParamMixerDecoratorMetadata : audioEmitterMetadata
	{
		private CArray<audioMixParamDescription> _inParams;
		private CName _outputName;
		private CEnum<audioMixParamsAction> _operation;
		private CBool _globalOutput;

		[Ordinal(1)] 
		[RED("inParams")] 
		public CArray<audioMixParamDescription> InParams
		{
			get => GetProperty(ref _inParams);
			set => SetProperty(ref _inParams, value);
		}

		[Ordinal(2)] 
		[RED("outputName")] 
		public CName OutputName
		{
			get => GetProperty(ref _outputName);
			set => SetProperty(ref _outputName, value);
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<audioMixParamsAction> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(4)] 
		[RED("globalOutput")] 
		public CBool GlobalOutput
		{
			get => GetProperty(ref _globalOutput);
			set => SetProperty(ref _globalOutput, value);
		}

		public audioParamMixerDecoratorMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
