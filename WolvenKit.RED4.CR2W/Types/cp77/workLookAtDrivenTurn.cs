using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workLookAtDrivenTurn : workIEntry
	{
		private CInt32 _turnAngle;
		private CName _turnAnimName;
		private CFloat _blendTime;

		[Ordinal(2)] 
		[RED("turnAngle")] 
		public CInt32 TurnAngle
		{
			get
			{
				if (_turnAngle == null)
				{
					_turnAngle = (CInt32) CR2WTypeManager.Create("Int32", "turnAngle", cr2w, this);
				}
				return _turnAngle;
			}
			set
			{
				if (_turnAngle == value)
				{
					return;
				}
				_turnAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("turnAnimName")] 
		public CName TurnAnimName
		{
			get
			{
				if (_turnAnimName == null)
				{
					_turnAnimName = (CName) CR2WTypeManager.Create("CName", "turnAnimName", cr2w, this);
				}
				return _turnAnimName;
			}
			set
			{
				if (_turnAnimName == value)
				{
					return;
				}
				_turnAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		public workLookAtDrivenTurn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
