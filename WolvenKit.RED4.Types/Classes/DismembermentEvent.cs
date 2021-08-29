using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DismembermentEvent : redEvent
	{
		private CEnum<gameDismBodyPart> _bodyPart;
		private CEnum<gameDismWoundType> _woundType;
		private CFloat _strength;
		private CBool _isCritical;
		private CString _debrisPath;
		private CFloat _debrisStrength;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CEnum<gameDismWoundType> WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(2)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(3)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetProperty(ref _isCritical);
			set => SetProperty(ref _isCritical, value);
		}

		[Ordinal(4)] 
		[RED("debrisPath")] 
		public CString DebrisPath
		{
			get => GetProperty(ref _debrisPath);
			set => SetProperty(ref _debrisPath, value);
		}

		[Ordinal(5)] 
		[RED("debrisStrength")] 
		public CFloat DebrisStrength
		{
			get => GetProperty(ref _debrisStrength);
			set => SetProperty(ref _debrisStrength, value);
		}
	}
}
