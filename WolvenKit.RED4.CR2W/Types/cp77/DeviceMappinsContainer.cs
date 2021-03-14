using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceMappinsContainer : IScriptable
	{
		private CArray<SDeviceMappinData> _mappins;
		private SDeviceMappinData _newNewFocusMappin;
		private CBool _useNewFocusMappin;
		private CFloat _offsetValue;

		[Ordinal(0)] 
		[RED("mappins")] 
		public CArray<SDeviceMappinData> Mappins
		{
			get
			{
				if (_mappins == null)
				{
					_mappins = (CArray<SDeviceMappinData>) CR2WTypeManager.Create("array:SDeviceMappinData", "mappins", cr2w, this);
				}
				return _mappins;
			}
			set
			{
				if (_mappins == value)
				{
					return;
				}
				_mappins = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newNewFocusMappin")] 
		public SDeviceMappinData NewNewFocusMappin
		{
			get
			{
				if (_newNewFocusMappin == null)
				{
					_newNewFocusMappin = (SDeviceMappinData) CR2WTypeManager.Create("SDeviceMappinData", "newNewFocusMappin", cr2w, this);
				}
				return _newNewFocusMappin;
			}
			set
			{
				if (_newNewFocusMappin == value)
				{
					return;
				}
				_newNewFocusMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useNewFocusMappin")] 
		public CBool UseNewFocusMappin
		{
			get
			{
				if (_useNewFocusMappin == null)
				{
					_useNewFocusMappin = (CBool) CR2WTypeManager.Create("Bool", "useNewFocusMappin", cr2w, this);
				}
				return _useNewFocusMappin;
			}
			set
			{
				if (_useNewFocusMappin == value)
				{
					return;
				}
				_useNewFocusMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetValue")] 
		public CFloat OffsetValue
		{
			get
			{
				if (_offsetValue == null)
				{
					_offsetValue = (CFloat) CR2WTypeManager.Create("Float", "offsetValue", cr2w, this);
				}
				return _offsetValue;
			}
			set
			{
				if (_offsetValue == value)
				{
					return;
				}
				_offsetValue = value;
				PropertySet(this);
			}
		}

		public DeviceMappinsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
