using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ProceduralIronsightData : animAnimFeature
	{
		private CBool _hasScope;
		private CBool _isEnabled;
		private CFloat _offset;
		private CFloat _scopeOffset;
		private Vector4 _position;
		private Quaternion _rotation;

		[Ordinal(0)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get
			{
				if (_hasScope == null)
				{
					_hasScope = (CBool) CR2WTypeManager.Create("Bool", "hasScope", cr2w, this);
				}
				return _hasScope;
			}
			set
			{
				if (_hasScope == value)
				{
					return;
				}
				_hasScope = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CFloat) CR2WTypeManager.Create("Float", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scopeOffset")] 
		public CFloat ScopeOffset
		{
			get
			{
				if (_scopeOffset == null)
				{
					_scopeOffset = (CFloat) CR2WTypeManager.Create("Float", "scopeOffset", cr2w, this);
				}
				return _scopeOffset;
			}
			set
			{
				if (_scopeOffset == value)
				{
					return;
				}
				_scopeOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
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

		[Ordinal(5)] 
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

		public AnimFeature_ProceduralIronsightData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
