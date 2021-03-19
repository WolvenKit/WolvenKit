using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingResult : CVariable
	{
		private Vector4 _slidingDirection;
		private Vector4 _normalDirection;
		private Vector4 _lowestLocalPosition;
		private CFloat _staticGroundFactor;
		private CEnum<moveSecureFootingFailureReason> _reason;
		private CEnum<moveSecureFootingFailureType> _type;

		[Ordinal(0)] 
		[RED("slidingDirection")] 
		public Vector4 SlidingDirection
		{
			get => GetProperty(ref _slidingDirection);
			set => SetProperty(ref _slidingDirection, value);
		}

		[Ordinal(1)] 
		[RED("normalDirection")] 
		public Vector4 NormalDirection
		{
			get => GetProperty(ref _normalDirection);
			set => SetProperty(ref _normalDirection, value);
		}

		[Ordinal(2)] 
		[RED("lowestLocalPosition")] 
		public Vector4 LowestLocalPosition
		{
			get => GetProperty(ref _lowestLocalPosition);
			set => SetProperty(ref _lowestLocalPosition, value);
		}

		[Ordinal(3)] 
		[RED("staticGroundFactor")] 
		public CFloat StaticGroundFactor
		{
			get => GetProperty(ref _staticGroundFactor);
			set => SetProperty(ref _staticGroundFactor, value);
		}

		[Ordinal(4)] 
		[RED("reason")] 
		public CEnum<moveSecureFootingFailureReason> Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<moveSecureFootingFailureType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public moveSecureFootingResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
