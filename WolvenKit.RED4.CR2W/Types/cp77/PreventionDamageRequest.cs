using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDamageRequest : gameScriptableSystemRequest
	{
		private CBool _isInternal;
		private CFloat _damagePercentValue;
		private entEntityID _targetID;
		private Vector4 _targetPosition;
		private CBool _isTargetAlive;
		private CBool _isTargetPrevention;

		[Ordinal(0)] 
		[RED("isInternal")] 
		public CBool IsInternal
		{
			get => GetProperty(ref _isInternal);
			set => SetProperty(ref _isInternal, value);
		}

		[Ordinal(1)] 
		[RED("damagePercentValue")] 
		public CFloat DamagePercentValue
		{
			get => GetProperty(ref _damagePercentValue);
			set => SetProperty(ref _damagePercentValue, value);
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(4)] 
		[RED("isTargetAlive")] 
		public CBool IsTargetAlive
		{
			get => GetProperty(ref _isTargetAlive);
			set => SetProperty(ref _isTargetAlive, value);
		}

		[Ordinal(5)] 
		[RED("isTargetPrevention")] 
		public CBool IsTargetPrevention
		{
			get => GetProperty(ref _isTargetPrevention);
			set => SetProperty(ref _isTargetPrevention, value);
		}

		public PreventionDamageRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
