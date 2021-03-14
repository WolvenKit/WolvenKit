using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCameraManagerComponentPS : gameComponentPS
	{
		private CEnum<vehicleCameraPerspective> _perspective;

		[Ordinal(0)] 
		[RED("perspective")] 
		public CEnum<vehicleCameraPerspective> Perspective
		{
			get
			{
				if (_perspective == null)
				{
					_perspective = (CEnum<vehicleCameraPerspective>) CR2WTypeManager.Create("vehicleCameraPerspective", "perspective", cr2w, this);
				}
				return _perspective;
			}
			set
			{
				if (_perspective == value)
				{
					return;
				}
				_perspective = value;
				PropertySet(this);
			}
		}

		public vehicleCameraManagerComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
