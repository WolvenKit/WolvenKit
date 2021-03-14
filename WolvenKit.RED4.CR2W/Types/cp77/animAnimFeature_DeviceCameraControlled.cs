using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DeviceCameraControlled : animAnimFeature
	{
		private Vector4 _currentRotation;

		[Ordinal(0)] 
		[RED("currentRotation")] 
		public Vector4 CurrentRotation
		{
			get
			{
				if (_currentRotation == null)
				{
					_currentRotation = (Vector4) CR2WTypeManager.Create("Vector4", "currentRotation", cr2w, this);
				}
				return _currentRotation;
			}
			set
			{
				if (_currentRotation == value)
				{
					return;
				}
				_currentRotation = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_DeviceCameraControlled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
