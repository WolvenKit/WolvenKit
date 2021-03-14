using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewCameraSetup : CVariable
	{
		private CName _slotName;
		private CFloat _cameraZoom;
		private CFloat _interpolationTime;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cameraZoom")] 
		public CFloat CameraZoom
		{
			get
			{
				if (_cameraZoom == null)
				{
					_cameraZoom = (CFloat) CR2WTypeManager.Create("Float", "cameraZoom", cr2w, this);
				}
				return _cameraZoom;
			}
			set
			{
				if (_cameraZoom == value)
				{
					return;
				}
				_cameraZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interpolationTime")] 
		public CFloat InterpolationTime
		{
			get
			{
				if (_interpolationTime == null)
				{
					_interpolationTime = (CFloat) CR2WTypeManager.Create("Float", "interpolationTime", cr2w, this);
				}
				return _interpolationTime;
			}
			set
			{
				if (_interpolationTime == value)
				{
					return;
				}
				_interpolationTime = value;
				PropertySet(this);
			}
		}

		public gameuiPuppetPreviewCameraSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
