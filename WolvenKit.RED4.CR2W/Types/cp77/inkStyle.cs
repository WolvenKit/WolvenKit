using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyle : CVariable
	{
		private CName _styleID;
		private CName _state;
		private CArray<inkStyleProperty> _properties;

		[Ordinal(0)] 
		[RED("styleID")] 
		public CName StyleID
		{
			get
			{
				if (_styleID == null)
				{
					_styleID = (CName) CR2WTypeManager.Create("CName", "styleID", cr2w, this);
				}
				return _styleID;
			}
			set
			{
				if (_styleID == value)
				{
					return;
				}
				_styleID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CName State
		{
			get
			{
				if (_state == null)
				{
					_state = (CName) CR2WTypeManager.Create("CName", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("properties")] 
		public CArray<inkStyleProperty> Properties
		{
			get
			{
				if (_properties == null)
				{
					_properties = (CArray<inkStyleProperty>) CR2WTypeManager.Create("array:inkStyleProperty", "properties", cr2w, this);
				}
				return _properties;
			}
			set
			{
				if (_properties == value)
				{
					return;
				}
				_properties = value;
				PropertySet(this);
			}
		}

		public inkStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
