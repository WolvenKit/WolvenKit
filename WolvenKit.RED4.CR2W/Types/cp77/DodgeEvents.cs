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
			get
			{
				if (_blockStatFlag == null)
				{
					_blockStatFlag = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "blockStatFlag", cr2w, this);
				}
				return _blockStatFlag;
			}
			set
			{
				if (_blockStatFlag == value)
				{
					return;
				}
				_blockStatFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("decelerationModifier")] 
		public CHandle<gameStatModifierData> DecelerationModifier
		{
			get
			{
				if (_decelerationModifier == null)
				{
					_decelerationModifier = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "decelerationModifier", cr2w, this);
				}
				return _decelerationModifier;
			}
			set
			{
				if (_decelerationModifier == value)
				{
					return;
				}
				_decelerationModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pressureWaveCreated")] 
		public CBool PressureWaveCreated
		{
			get
			{
				if (_pressureWaveCreated == null)
				{
					_pressureWaveCreated = (CBool) CR2WTypeManager.Create("Bool", "pressureWaveCreated", cr2w, this);
				}
				return _pressureWaveCreated;
			}
			set
			{
				if (_pressureWaveCreated == value)
				{
					return;
				}
				_pressureWaveCreated = value;
				PropertySet(this);
			}
		}

		public DodgeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
