using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitResult : CVariable
	{
		private Vector4 _hitPositionEnter;
		private Vector4 _hitPositionExit;
		private CFloat _enterDistanceFromOriginSq;

		[Ordinal(0)] 
		[RED("hitPositionEnter")] 
		public Vector4 HitPositionEnter
		{
			get
			{
				if (_hitPositionEnter == null)
				{
					_hitPositionEnter = (Vector4) CR2WTypeManager.Create("Vector4", "hitPositionEnter", cr2w, this);
				}
				return _hitPositionEnter;
			}
			set
			{
				if (_hitPositionEnter == value)
				{
					return;
				}
				_hitPositionEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitPositionExit")] 
		public Vector4 HitPositionExit
		{
			get
			{
				if (_hitPositionExit == null)
				{
					_hitPositionExit = (Vector4) CR2WTypeManager.Create("Vector4", "hitPositionExit", cr2w, this);
				}
				return _hitPositionExit;
			}
			set
			{
				if (_hitPositionExit == value)
				{
					return;
				}
				_hitPositionExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enterDistanceFromOriginSq")] 
		public CFloat EnterDistanceFromOriginSq
		{
			get
			{
				if (_enterDistanceFromOriginSq == null)
				{
					_enterDistanceFromOriginSq = (CFloat) CR2WTypeManager.Create("Float", "enterDistanceFromOriginSq", cr2w, this);
				}
				return _enterDistanceFromOriginSq;
			}
			set
			{
				if (_enterDistanceFromOriginSq == value)
				{
					return;
				}
				_enterDistanceFromOriginSq = value;
				PropertySet(this);
			}
		}

		public gameHitResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
