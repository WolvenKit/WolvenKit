using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeParams : questAICommandParams
	{
		private CEnum<questMoveType> _moveType;
		private CHandle<questMoveOnSplineParams> _moveOnSplineParams;
		private CHandle<questMoveToParams> _moveToParams;
		private CHandle<questAICommandParams> _otherParams;
		private CBool _repeatCommandOnInterrupt;

		[Ordinal(0)] 
		[RED("moveType")] 
		public CEnum<questMoveType> MoveType
		{
			get => GetProperty(ref _moveType);
			set => SetProperty(ref _moveType, value);
		}

		[Ordinal(1)] 
		[RED("moveOnSplineParams")] 
		public CHandle<questMoveOnSplineParams> MoveOnSplineParams
		{
			get => GetProperty(ref _moveOnSplineParams);
			set => SetProperty(ref _moveOnSplineParams, value);
		}

		[Ordinal(2)] 
		[RED("moveToParams")] 
		public CHandle<questMoveToParams> MoveToParams
		{
			get => GetProperty(ref _moveToParams);
			set => SetProperty(ref _moveToParams, value);
		}

		[Ordinal(3)] 
		[RED("otherParams")] 
		public CHandle<questAICommandParams> OtherParams
		{
			get => GetProperty(ref _otherParams);
			set => SetProperty(ref _otherParams, value);
		}

		[Ordinal(4)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetProperty(ref _repeatCommandOnInterrupt);
			set => SetProperty(ref _repeatCommandOnInterrupt, value);
		}

		public questMovePuppetNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
