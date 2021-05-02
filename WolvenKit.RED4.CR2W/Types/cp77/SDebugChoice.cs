using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDebugChoice : CVariable
	{
		private CName _choiceName;
		private CInt32 _factValue;
		private CEnum<EVarDBMode> _factmode;

		[Ordinal(0)] 
		[RED("choiceName")] 
		public CName ChoiceName
		{
			get => GetProperty(ref _choiceName);
			set => SetProperty(ref _choiceName, value);
		}

		[Ordinal(1)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetProperty(ref _factValue);
			set => SetProperty(ref _factValue, value);
		}

		[Ordinal(2)] 
		[RED("factmode")] 
		public CEnum<EVarDBMode> Factmode
		{
			get => GetProperty(ref _factmode);
			set => SetProperty(ref _factmode, value);
		}

		public SDebugChoice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
