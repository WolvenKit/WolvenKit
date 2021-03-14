using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleProperty : CVariable
	{
		private CName _propertyPath;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("propertyPath")] 
		public CName PropertyPath
		{
			get
			{
				if (_propertyPath == null)
				{
					_propertyPath = (CName) CR2WTypeManager.Create("CName", "propertyPath", cr2w, this);
				}
				return _propertyPath;
			}
			set
			{
				if (_propertyPath == value)
				{
					return;
				}
				_propertyPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CVariant Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CVariant) CR2WTypeManager.Create("Variant", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public inkStyleProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
