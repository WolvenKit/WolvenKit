using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldGINode : worldNode
	{
		private raRef<CGIDataResource> _data;
		private CArrayFixedSize<CInt16> _location;

		[Ordinal(4)] 
		[RED("data")] 
		public raRef<CGIDataResource> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (raRef<CGIDataResource>) CR2WTypeManager.Create("raRef:CGIDataResource", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("location", 3)] 
		public CArrayFixedSize<CInt16> Location
		{
			get
			{
				if (_location == null)
				{
					_location = (CArrayFixedSize<CInt16>) CR2WTypeManager.Create("[3]Int16", "location", cr2w, this);
				}
				return _location;
			}
			set
			{
				if (_location == value)
				{
					return;
				}
				_location = value;
				PropertySet(this);
			}
		}

		public worldGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
