using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformConstant : animAnimNode_TransformValue
	{
		private Vector4 _pos;
		private Quaternion _rotation;
		private Vector4 _scale;

		[Ordinal(11)] 
		[RED("pos")] 
		public Vector4 Pos
		{
			get
			{
				if (_pos == null)
				{
					_pos = (Vector4) CR2WTypeManager.Create("Vector4", "pos", cr2w, this);
				}
				return _pos;
			}
			set
			{
				if (_pos == value)
				{
					return;
				}
				_pos = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("scale")] 
		public Vector4 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector4) CR2WTypeManager.Create("Vector4", "scale", cr2w, this);
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

		public animAnimNode_TransformConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
