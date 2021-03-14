using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Cylinder : CVariable
	{
		private Vector4 _positionAndRadius;
		private Vector4 _normalAndHeight;

		[Ordinal(0)] 
		[RED("positionAndRadius")] 
		public Vector4 PositionAndRadius
		{
			get
			{
				if (_positionAndRadius == null)
				{
					_positionAndRadius = (Vector4) CR2WTypeManager.Create("Vector4", "positionAndRadius", cr2w, this);
				}
				return _positionAndRadius;
			}
			set
			{
				if (_positionAndRadius == value)
				{
					return;
				}
				_positionAndRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("normalAndHeight")] 
		public Vector4 NormalAndHeight
		{
			get
			{
				if (_normalAndHeight == null)
				{
					_normalAndHeight = (Vector4) CR2WTypeManager.Create("Vector4", "normalAndHeight", cr2w, this);
				}
				return _normalAndHeight;
			}
			set
			{
				if (_normalAndHeight == value)
				{
					return;
				}
				_normalAndHeight = value;
				PropertySet(this);
			}
		}

		public Cylinder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
