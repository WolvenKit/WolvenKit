using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WrapperValue : animAnimNode_FloatValue
	{
		private CArray<CName> _wrapperNames;
		private CEnum<animEAnimGraphLogicOp> _logicOp;
		private CBool _oneMinus;

		[Ordinal(11)] 
		[RED("wrapperNames")] 
		public CArray<CName> WrapperNames
		{
			get => GetProperty(ref _wrapperNames);
			set => SetProperty(ref _wrapperNames, value);
		}

		[Ordinal(12)] 
		[RED("logicOp")] 
		public CEnum<animEAnimGraphLogicOp> LogicOp
		{
			get => GetProperty(ref _logicOp);
			set => SetProperty(ref _logicOp, value);
		}

		[Ordinal(13)] 
		[RED("oneMinus")] 
		public CBool OneMinus
		{
			get => GetProperty(ref _oneMinus);
			set => SetProperty(ref _oneMinus, value);
		}

		public animAnimNode_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
