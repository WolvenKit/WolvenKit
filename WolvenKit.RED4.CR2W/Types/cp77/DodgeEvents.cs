using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DodgeEvents : LocomotionGroundEvents
	{
		private CHandle<gameStatModifierData> _blockStatFlag;
		private CHandle<gameStatModifierData> _decelerationModifier;
		private CBool _pressureWaveCreated;

		[Ordinal(0)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData> BlockStatFlag
		{
			get => GetProperty(ref _blockStatFlag);
			set => SetProperty(ref _blockStatFlag, value);
		}

		[Ordinal(1)] 
		[RED("decelerationModifier")] 
		public CHandle<gameStatModifierData> DecelerationModifier
		{
			get => GetProperty(ref _decelerationModifier);
			set => SetProperty(ref _decelerationModifier, value);
		}

		[Ordinal(2)] 
		[RED("pressureWaveCreated")] 
		public CBool PressureWaveCreated
		{
			get => GetProperty(ref _pressureWaveCreated);
			set => SetProperty(ref _pressureWaveCreated, value);
		}

		public DodgeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
