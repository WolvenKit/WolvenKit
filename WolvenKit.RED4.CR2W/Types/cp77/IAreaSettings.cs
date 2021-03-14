using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IAreaSettings : ISerializable
	{
		private CBool _enable;
		private CUInt64 _disabledIndexedProperties;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disabledIndexedProperties")] 
		public CUInt64 DisabledIndexedProperties
		{
			get
			{
				if (_disabledIndexedProperties == null)
				{
					_disabledIndexedProperties = (CUInt64) CR2WTypeManager.Create("Uint64", "disabledIndexedProperties", cr2w, this);
				}
				return _disabledIndexedProperties;
			}
			set
			{
				if (_disabledIndexedProperties == value)
				{
					return;
				}
				_disabledIndexedProperties = value;
				PropertySet(this);
			}
		}

		public IAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
