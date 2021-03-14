using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVirtualCameraViewComponent : entIVisualComponent
	{
		private CName _virtualCameraName;
		private Vector2 _targetPlaneSize;

		[Ordinal(8)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get
			{
				if (_virtualCameraName == null)
				{
					_virtualCameraName = (CName) CR2WTypeManager.Create("CName", "virtualCameraName", cr2w, this);
				}
				return _virtualCameraName;
			}
			set
			{
				if (_virtualCameraName == value)
				{
					return;
				}
				_virtualCameraName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("targetPlaneSize")] 
		public Vector2 TargetPlaneSize
		{
			get
			{
				if (_targetPlaneSize == null)
				{
					_targetPlaneSize = (Vector2) CR2WTypeManager.Create("Vector2", "targetPlaneSize", cr2w, this);
				}
				return _targetPlaneSize;
			}
			set
			{
				if (_targetPlaneSize == value)
				{
					return;
				}
				_targetPlaneSize = value;
				PropertySet(this);
			}
		}

		public entVirtualCameraViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
