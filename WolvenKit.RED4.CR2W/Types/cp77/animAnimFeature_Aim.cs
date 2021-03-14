using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Aim : animAnimFeature_BasicAim
	{
		private Vector4 _aimPoint;

		[Ordinal(2)] 
		[RED("aimPoint")] 
		public Vector4 AimPoint
		{
			get
			{
				if (_aimPoint == null)
				{
					_aimPoint = (Vector4) CR2WTypeManager.Create("Vector4", "aimPoint", cr2w, this);
				}
				return _aimPoint;
			}
			set
			{
				if (_aimPoint == value)
				{
					return;
				}
				_aimPoint = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Aim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
