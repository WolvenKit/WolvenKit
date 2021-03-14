using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FeedEvent : redEvent
	{
		private CBool _on;
		private CName _virtualComponentName;
		private entEntityID _cameraID;

		[Ordinal(0)] 
		[RED("On")] 
		public CBool On
		{
			get
			{
				if (_on == null)
				{
					_on = (CBool) CR2WTypeManager.Create("Bool", "On", cr2w, this);
				}
				return _on;
			}
			set
			{
				if (_on == value)
				{
					return;
				}
				_on = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get
			{
				if (_virtualComponentName == null)
				{
					_virtualComponentName = (CName) CR2WTypeManager.Create("CName", "virtualComponentName", cr2w, this);
				}
				return _virtualComponentName;
			}
			set
			{
				if (_virtualComponentName == value)
				{
					return;
				}
				_virtualComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cameraID")] 
		public entEntityID CameraID
		{
			get
			{
				if (_cameraID == null)
				{
					_cameraID = (entEntityID) CR2WTypeManager.Create("entEntityID", "cameraID", cr2w, this);
				}
				return _cameraID;
			}
			set
			{
				if (_cameraID == value)
				{
					return;
				}
				_cameraID = value;
				PropertySet(this);
			}
		}

		public FeedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
