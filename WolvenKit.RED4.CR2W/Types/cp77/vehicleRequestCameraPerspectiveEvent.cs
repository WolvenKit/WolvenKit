using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleRequestCameraPerspectiveEvent : redEvent
	{
		private CEnum<vehicleCameraPerspective> _cameraPerspective;

		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<vehicleCameraPerspective> CameraPerspective
		{
			get
			{
				if (_cameraPerspective == null)
				{
					_cameraPerspective = (CEnum<vehicleCameraPerspective>) CR2WTypeManager.Create("vehicleCameraPerspective", "cameraPerspective", cr2w, this);
				}
				return _cameraPerspective;
			}
			set
			{
				if (_cameraPerspective == value)
				{
					return;
				}
				_cameraPerspective = value;
				PropertySet(this);
			}
		}

		public vehicleRequestCameraPerspectiveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
