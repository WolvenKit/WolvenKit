using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialTransformNoScale : CVariable
	{
		private Quaternion _rotation;
		private Vector3 _translation;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		public animImportFacialTransformNoScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
