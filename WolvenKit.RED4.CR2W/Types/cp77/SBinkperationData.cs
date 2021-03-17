using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBinkperationData : CVariable
	{
		private CName _componentName;
		private redResourceReferenceScriptToken _binkPath;
		private CBool _loop;
		private CEnum<EBinkOperationType> _operationType;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("binkPath")] 
		public redResourceReferenceScriptToken BinkPath
		{
			get => GetProperty(ref _binkPath);
			set => SetProperty(ref _binkPath, value);
		}

		[Ordinal(2)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EBinkOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		public SBinkperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
