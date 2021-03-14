using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CycleRoundEvents : WeaponEventsTransition
	{
		private CBool _hasBlockedAiming;
		private CFloat _blockAimStart;
		private CFloat _blockAimDuration;

		[Ordinal(0)] 
		[RED("hasBlockedAiming")] 
		public CBool HasBlockedAiming
		{
			get
			{
				if (_hasBlockedAiming == null)
				{
					_hasBlockedAiming = (CBool) CR2WTypeManager.Create("Bool", "hasBlockedAiming", cr2w, this);
				}
				return _hasBlockedAiming;
			}
			set
			{
				if (_hasBlockedAiming == value)
				{
					return;
				}
				_hasBlockedAiming = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blockAimStart")] 
		public CFloat BlockAimStart
		{
			get
			{
				if (_blockAimStart == null)
				{
					_blockAimStart = (CFloat) CR2WTypeManager.Create("Float", "blockAimStart", cr2w, this);
				}
				return _blockAimStart;
			}
			set
			{
				if (_blockAimStart == value)
				{
					return;
				}
				_blockAimStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blockAimDuration")] 
		public CFloat BlockAimDuration
		{
			get
			{
				if (_blockAimDuration == null)
				{
					_blockAimDuration = (CFloat) CR2WTypeManager.Create("Float", "blockAimDuration", cr2w, this);
				}
				return _blockAimDuration;
			}
			set
			{
				if (_blockAimDuration == value)
				{
					return;
				}
				_blockAimDuration = value;
				PropertySet(this);
			}
		}

		public CycleRoundEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
