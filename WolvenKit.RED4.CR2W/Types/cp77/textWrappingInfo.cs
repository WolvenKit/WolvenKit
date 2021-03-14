using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textWrappingInfo : CVariable
	{
		private CBool _autoWrappingEnabled;
		private CFloat _wrappingAtPosition;
		private CEnum<textWrappingPolicy> _wrappingPolicy;

		[Ordinal(0)] 
		[RED("autoWrappingEnabled")] 
		public CBool AutoWrappingEnabled
		{
			get
			{
				if (_autoWrappingEnabled == null)
				{
					_autoWrappingEnabled = (CBool) CR2WTypeManager.Create("Bool", "autoWrappingEnabled", cr2w, this);
				}
				return _autoWrappingEnabled;
			}
			set
			{
				if (_autoWrappingEnabled == value)
				{
					return;
				}
				_autoWrappingEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wrappingAtPosition")] 
		public CFloat WrappingAtPosition
		{
			get
			{
				if (_wrappingAtPosition == null)
				{
					_wrappingAtPosition = (CFloat) CR2WTypeManager.Create("Float", "wrappingAtPosition", cr2w, this);
				}
				return _wrappingAtPosition;
			}
			set
			{
				if (_wrappingAtPosition == value)
				{
					return;
				}
				_wrappingAtPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wrappingPolicy")] 
		public CEnum<textWrappingPolicy> WrappingPolicy
		{
			get
			{
				if (_wrappingPolicy == null)
				{
					_wrappingPolicy = (CEnum<textWrappingPolicy>) CR2WTypeManager.Create("textWrappingPolicy", "wrappingPolicy", cr2w, this);
				}
				return _wrappingPolicy;
			}
			set
			{
				if (_wrappingPolicy == value)
				{
					return;
				}
				_wrappingPolicy = value;
				PropertySet(this);
			}
		}

		public textWrappingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
