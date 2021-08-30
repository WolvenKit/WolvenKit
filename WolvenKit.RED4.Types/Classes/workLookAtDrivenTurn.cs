using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workLookAtDrivenTurn : workIEntry
	{
		private CInt32 _turnAngle;
		private CName _turnAnimName;
		private CFloat _blendTime;

		[Ordinal(2)] 
		[RED("turnAngle")] 
		public CInt32 TurnAngle
		{
			get => GetProperty(ref _turnAngle);
			set => SetProperty(ref _turnAngle, value);
		}

		[Ordinal(3)] 
		[RED("turnAnimName")] 
		public CName TurnAnimName
		{
			get => GetProperty(ref _turnAnimName);
			set => SetProperty(ref _turnAnimName, value);
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		public workLookAtDrivenTurn()
		{
			_blendTime = 0.500000F;
		}
	}
}
