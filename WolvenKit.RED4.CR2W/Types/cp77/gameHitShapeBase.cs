using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeBase : gameIHitShape
	{
		private Vector3 _translation;
		private Quaternion _rotation;
		private CMatrix _localTransform;

		[Ordinal(0)] 
		[RED("translation")] 
		public Vector3 Translation
		{
			get
			{
				if (_translation == null)
				{
					_translation = (Vector3) CR2WTypeManager.Create("Vector3", "translation", cr2w, this);
				}
				return _translation;
			}
			set
			{
				if (_translation == value)
				{
					return;
				}
				_translation = value;
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
		[RED("localTransform")] 
		public CMatrix LocalTransform
		{
			get
			{
				if (_localTransform == null)
				{
					_localTransform = (CMatrix) CR2WTypeManager.Create("Matrix", "localTransform", cr2w, this);
				}
				return _localTransform;
			}
			set
			{
				if (_localTransform == value)
				{
					return;
				}
				_localTransform = value;
				PropertySet(this);
			}
		}

		public gameHitShapeBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
