using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CutCone : CVariable
	{
		private Vector4 _positionAndRadius1;
		private Vector4 _normalAndRadius2;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("positionAndRadius1")] 
		public Vector4 PositionAndRadius1
		{
			get
			{
				if (_positionAndRadius1 == null)
				{
					_positionAndRadius1 = (Vector4) CR2WTypeManager.Create("Vector4", "positionAndRadius1", cr2w, this);
				}
				return _positionAndRadius1;
			}
			set
			{
				if (_positionAndRadius1 == value)
				{
					return;
				}
				_positionAndRadius1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("normalAndRadius2")] 
		public Vector4 NormalAndRadius2
		{
			get
			{
				if (_normalAndRadius2 == null)
				{
					_normalAndRadius2 = (Vector4) CR2WTypeManager.Create("Vector4", "normalAndRadius2", cr2w, this);
				}
				return _normalAndRadius2;
			}
			set
			{
				if (_normalAndRadius2 == value)
				{
					return;
				}
				_normalAndRadius2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		public CutCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
