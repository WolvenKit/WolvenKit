using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimMathExpressionFloatSocket : CVariable
	{
		private animFloatLink _link;
		private CUInt16 _expressionVarId;
		private animNamedTrackIndex _inputFloatTrack;

		[Ordinal(0)] 
		[RED("link")] 
		public animFloatLink Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get => GetProperty(ref _expressionVarId);
			set => SetProperty(ref _expressionVarId, value);
		}

		[Ordinal(2)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get => GetProperty(ref _inputFloatTrack);
			set => SetProperty(ref _inputFloatTrack, value);
		}

		public animAnimMathExpressionFloatSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
