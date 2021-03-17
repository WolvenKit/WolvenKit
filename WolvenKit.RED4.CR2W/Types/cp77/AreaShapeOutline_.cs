using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaShapeOutline_ : ISerializable
	{
		private CArray<Vector3> _points;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector3> Points
		{
			get => _points ??= Create<CArray<Vector3>>();
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet();
			}
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CFloat Height
		{
			get => _height ??= Create<CFloat>();
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet();
			}
		}

		public AreaShapeOutline_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
