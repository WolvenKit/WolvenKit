using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVendorData : CVariable
	{
		private CString _vendorId;
		private entEntityID _entityID;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("vendorId")] 
		public CString VendorId
		{
			get
			{
				if (_vendorId == null)
				{
					_vendorId = (CString) CR2WTypeManager.Create("String", "vendorId", cr2w, this);
				}
				return _vendorId;
			}
			set
			{
				if (_vendorId == value)
				{
					return;
				}
				_vendorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public gameVendorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
