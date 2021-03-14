using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponShootParams : CVariable
	{
		private Vector4 _fromWorldPosition;
		private Vector4 _forward;

		[Ordinal(0)] 
		[RED("fromWorldPosition")] 
		public Vector4 FromWorldPosition
		{
			get
			{
				if (_fromWorldPosition == null)
				{
					_fromWorldPosition = (Vector4) CR2WTypeManager.Create("Vector4", "fromWorldPosition", cr2w, this);
				}
				return _fromWorldPosition;
			}
			set
			{
				if (_fromWorldPosition == value)
				{
					return;
				}
				_fromWorldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get
			{
				if (_forward == null)
				{
					_forward = (Vector4) CR2WTypeManager.Create("Vector4", "forward", cr2w, this);
				}
				return _forward;
			}
			set
			{
				if (_forward == value)
				{
					return;
				}
				_forward = value;
				PropertySet(this);
			}
		}

		public gameuiWeaponShootParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
