using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SplinePoint : CVariable
	{
		private Vector3 _position;
		private Quaternion _rotation;
		private CArrayFixedSize<Vector3> _tangents;
		private CBool _continuousTangents;
		private CBool _automaticTangents;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("tangents", 2)] 
		public CArrayFixedSize<Vector3> Tangents
		{
			get
			{
				if (_tangents == null)
				{
					_tangents = (CArrayFixedSize<Vector3>) CR2WTypeManager.Create("[2]Vector3", "tangents", cr2w, this);
				}
				return _tangents;
			}
			set
			{
				if (_tangents == value)
				{
					return;
				}
				_tangents = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("continuousTangents")] 
		public CBool ContinuousTangents
		{
			get
			{
				if (_continuousTangents == null)
				{
					_continuousTangents = (CBool) CR2WTypeManager.Create("Bool", "continuousTangents", cr2w, this);
				}
				return _continuousTangents;
			}
			set
			{
				if (_continuousTangents == value)
				{
					return;
				}
				_continuousTangents = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("automaticTangents")] 
		public CBool AutomaticTangents
		{
			get
			{
				if (_automaticTangents == null)
				{
					_automaticTangents = (CBool) CR2WTypeManager.Create("Bool", "automaticTangents", cr2w, this);
				}
				return _automaticTangents;
			}
			set
			{
				if (_automaticTangents == value)
				{
					return;
				}
				_automaticTangents = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public SplinePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
