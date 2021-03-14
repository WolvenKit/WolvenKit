using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SAttribute : CVariable
	{
		private CEnum<gamedataStatType> _attributeName;
		private CInt32 _value;
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("attributeName")] 
		public CEnum<gamedataStatType> AttributeName
		{
			get
			{
				if (_attributeName == null)
				{
					_attributeName = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "attributeName", cr2w, this);
				}
				return _attributeName;
			}
			set
			{
				if (_attributeName == value)
				{
					return;
				}
				_attributeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
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

		[Ordinal(2)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "id", cr2w, this);
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

		public SAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
