using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetComparisonReportItem : CVariable
	{
		private CEnum<gameMuppetComparisonReportItemType> _type;
		private CString _propertyName;
		private CString _serverValue;
		private CString _clientValue;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameMuppetComparisonReportItemType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameMuppetComparisonReportItemType>) CR2WTypeManager.Create("gameMuppetComparisonReportItemType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("propertyName")] 
		public CString PropertyName
		{
			get
			{
				if (_propertyName == null)
				{
					_propertyName = (CString) CR2WTypeManager.Create("String", "propertyName", cr2w, this);
				}
				return _propertyName;
			}
			set
			{
				if (_propertyName == value)
				{
					return;
				}
				_propertyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("serverValue")] 
		public CString ServerValue
		{
			get
			{
				if (_serverValue == null)
				{
					_serverValue = (CString) CR2WTypeManager.Create("String", "serverValue", cr2w, this);
				}
				return _serverValue;
			}
			set
			{
				if (_serverValue == value)
				{
					return;
				}
				_serverValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("clientValue")] 
		public CString ClientValue
		{
			get
			{
				if (_clientValue == null)
				{
					_clientValue = (CString) CR2WTypeManager.Create("String", "clientValue", cr2w, this);
				}
				return _clientValue;
			}
			set
			{
				if (_clientValue == value)
				{
					return;
				}
				_clientValue = value;
				PropertySet(this);
			}
		}

		public gameMuppetComparisonReportItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
