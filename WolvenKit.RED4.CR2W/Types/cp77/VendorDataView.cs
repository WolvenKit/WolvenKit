using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorDataView : BackpackDataView
	{
		private CBool _isVendorGrid;
		private GameTime _openTime;

		[Ordinal(4)] 
		[RED("isVendorGrid")] 
		public CBool IsVendorGrid
		{
			get
			{
				if (_isVendorGrid == null)
				{
					_isVendorGrid = (CBool) CR2WTypeManager.Create("Bool", "isVendorGrid", cr2w, this);
				}
				return _isVendorGrid;
			}
			set
			{
				if (_isVendorGrid == value)
				{
					return;
				}
				_isVendorGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get
			{
				if (_openTime == null)
				{
					_openTime = (GameTime) CR2WTypeManager.Create("GameTime", "openTime", cr2w, this);
				}
				return _openTime;
			}
			set
			{
				if (_openTime == value)
				{
					return;
				}
				_openTime = value;
				PropertySet(this);
			}
		}

		public VendorDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
