using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDrawArea : CVariable
	{
		private Vector2 _size;
		private CFloat _scale;
		private Vector2 _relativePosition;
		private Vector2 _absolutePosition;

		[Ordinal(0)] 
		[RED("size")] 
		public Vector2 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector2) CR2WTypeManager.Create("Vector2", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("relativePosition")] 
		public Vector2 RelativePosition
		{
			get
			{
				if (_relativePosition == null)
				{
					_relativePosition = (Vector2) CR2WTypeManager.Create("Vector2", "relativePosition", cr2w, this);
				}
				return _relativePosition;
			}
			set
			{
				if (_relativePosition == value)
				{
					return;
				}
				_relativePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("absolutePosition")] 
		public Vector2 AbsolutePosition
		{
			get
			{
				if (_absolutePosition == null)
				{
					_absolutePosition = (Vector2) CR2WTypeManager.Create("Vector2", "absolutePosition", cr2w, this);
				}
				return _absolutePosition;
			}
			set
			{
				if (_absolutePosition == value)
				{
					return;
				}
				_absolutePosition = value;
				PropertySet(this);
			}
		}

		public inkDrawArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
