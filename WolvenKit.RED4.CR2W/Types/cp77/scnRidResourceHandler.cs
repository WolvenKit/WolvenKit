using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidResourceHandler : CVariable
	{
		private scnRidResourceId _id;
		private rRef<scnRidResource> _ridResource;

		[Ordinal(0)] 
		[RED("id")] 
		public scnRidResourceId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (scnRidResourceId) CR2WTypeManager.Create("scnRidResourceId", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ridResource")] 
		public rRef<scnRidResource> RidResource
		{
			get
			{
				if (_ridResource == null)
				{
					_ridResource = (rRef<scnRidResource>) CR2WTypeManager.Create("rRef:scnRidResource", "ridResource", cr2w, this);
				}
				return _ridResource;
			}
			set
			{
				if (_ridResource == value)
				{
					return;
				}
				_ridResource = value;
				PropertySet(this);
			}
		}

		public scnRidResourceHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
