using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargedThrowEvents : CombatGadgetTransitions
	{
		private CBool _grenadeThrown;
		private Vector4 _localAimForward;
		private Vector4 _localAimPosition;

		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get
			{
				if (_grenadeThrown == null)
				{
					_grenadeThrown = (CBool) CR2WTypeManager.Create("Bool", "grenadeThrown", cr2w, this);
				}
				return _grenadeThrown;
			}
			set
			{
				if (_grenadeThrown == value)
				{
					return;
				}
				_grenadeThrown = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localAimForward")] 
		public Vector4 LocalAimForward
		{
			get
			{
				if (_localAimForward == null)
				{
					_localAimForward = (Vector4) CR2WTypeManager.Create("Vector4", "localAimForward", cr2w, this);
				}
				return _localAimForward;
			}
			set
			{
				if (_localAimForward == value)
				{
					return;
				}
				_localAimForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localAimPosition")] 
		public Vector4 LocalAimPosition
		{
			get
			{
				if (_localAimPosition == null)
				{
					_localAimPosition = (Vector4) CR2WTypeManager.Create("Vector4", "localAimPosition", cr2w, this);
				}
				return _localAimPosition;
			}
			set
			{
				if (_localAimPosition == value)
				{
					return;
				}
				_localAimPosition = value;
				PropertySet(this);
			}
		}

		public CombatGadgetChargedThrowEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
