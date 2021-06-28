using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentInt : CheckArguments
	{
		private CInt32 _customVar;
		private CEnum<ECompareOp> _comparator;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CInt32 CustomVar
		{
			get => GetProperty(ref _customVar);
			set => SetProperty(ref _customVar, value);
		}

		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetProperty(ref _comparator);
			set => SetProperty(ref _comparator, value);
		}

		public CheckArgumentInt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
