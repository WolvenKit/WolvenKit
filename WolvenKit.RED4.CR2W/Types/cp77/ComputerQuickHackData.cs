using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerQuickHackData : CVariable
	{
		private TweakDBID _alternativeName;
		private CName _factName;
		private CInt32 _factValue;
		private CEnum<EMathOperationType> _operationType;

		[Ordinal(0)] 
		[RED("alternativeName")] 
		public TweakDBID AlternativeName
		{
			get => GetProperty(ref _alternativeName);
			set => SetProperty(ref _alternativeName, value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(2)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetProperty(ref _factValue);
			set => SetProperty(ref _factValue, value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EMathOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		public ComputerQuickHackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
