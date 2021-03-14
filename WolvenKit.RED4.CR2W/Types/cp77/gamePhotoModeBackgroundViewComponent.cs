using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundViewComponent : entIComponent
	{
		private NodeRef _backgroundPrefabRef;
		private NodeRef _targetPointRef;

		[Ordinal(3)] 
		[RED("backgroundPrefabRef")] 
		public NodeRef BackgroundPrefabRef
		{
			get
			{
				if (_backgroundPrefabRef == null)
				{
					_backgroundPrefabRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "backgroundPrefabRef", cr2w, this);
				}
				return _backgroundPrefabRef;
			}
			set
			{
				if (_backgroundPrefabRef == value)
				{
					return;
				}
				_backgroundPrefabRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetPointRef")] 
		public NodeRef TargetPointRef
		{
			get
			{
				if (_targetPointRef == null)
				{
					_targetPointRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetPointRef", cr2w, this);
				}
				return _targetPointRef;
			}
			set
			{
				if (_targetPointRef == value)
				{
					return;
				}
				_targetPointRef = value;
				PropertySet(this);
			}
		}

		public gamePhotoModeBackgroundViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
