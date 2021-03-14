using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _showAd;
		private CBool _showVendor;
		private CBool _locationAdded;

		[Ordinal(103)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get
			{
				if (_showAd == null)
				{
					_showAd = (CBool) CR2WTypeManager.Create("Bool", "showAd", cr2w, this);
				}
				return _showAd;
			}
			set
			{
				if (_showAd == value)
				{
					return;
				}
				_showAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get
			{
				if (_showVendor == null)
				{
					_showVendor = (CBool) CR2WTypeManager.Create("Bool", "showVendor", cr2w, this);
				}
				return _showVendor;
			}
			set
			{
				if (_showVendor == value)
				{
					return;
				}
				_showVendor = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("locationAdded")] 
		public CBool LocationAdded
		{
			get
			{
				if (_locationAdded == null)
				{
					_locationAdded = (CBool) CR2WTypeManager.Create("Bool", "locationAdded", cr2w, this);
				}
				return _locationAdded;
			}
			set
			{
				if (_locationAdded == value)
				{
					return;
				}
				_locationAdded = value;
				PropertySet(this);
			}
		}

		public InteractiveAdControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
