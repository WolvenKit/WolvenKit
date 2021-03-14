using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DodgeData : animAnimFeature
	{
		private CInt32 _dodgeType;
		private CInt32 _dodgeDirection;

		[Ordinal(0)] 
		[RED("dodgeType")] 
		public CInt32 DodgeType
		{
			get
			{
				if (_dodgeType == null)
				{
					_dodgeType = (CInt32) CR2WTypeManager.Create("Int32", "dodgeType", cr2w, this);
				}
				return _dodgeType;
			}
			set
			{
				if (_dodgeType == value)
				{
					return;
				}
				_dodgeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dodgeDirection")] 
		public CInt32 DodgeDirection
		{
			get
			{
				if (_dodgeDirection == null)
				{
					_dodgeDirection = (CInt32) CR2WTypeManager.Create("Int32", "dodgeDirection", cr2w, this);
				}
				return _dodgeDirection;
			}
			set
			{
				if (_dodgeDirection == value)
				{
					return;
				}
				_dodgeDirection = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_DodgeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
