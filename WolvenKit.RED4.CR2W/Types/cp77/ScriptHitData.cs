using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptHitData : CVariable
	{
		private CInt32 _animVariation;
		private CInt32 _attackDirection;
		private CInt32 _hitBodyPart;

		[Ordinal(0)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get
			{
				if (_animVariation == null)
				{
					_animVariation = (CInt32) CR2WTypeManager.Create("Int32", "animVariation", cr2w, this);
				}
				return _animVariation;
			}
			set
			{
				if (_animVariation == value)
				{
					return;
				}
				_animVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attackDirection")] 
		public CInt32 AttackDirection
		{
			get
			{
				if (_attackDirection == null)
				{
					_attackDirection = (CInt32) CR2WTypeManager.Create("Int32", "attackDirection", cr2w, this);
				}
				return _attackDirection;
			}
			set
			{
				if (_attackDirection == value)
				{
					return;
				}
				_attackDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get
			{
				if (_hitBodyPart == null)
				{
					_hitBodyPart = (CInt32) CR2WTypeManager.Create("Int32", "hitBodyPart", cr2w, this);
				}
				return _hitBodyPart;
			}
			set
			{
				if (_hitBodyPart == value)
				{
					return;
				}
				_hitBodyPart = value;
				PropertySet(this);
			}
		}

		public ScriptHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
