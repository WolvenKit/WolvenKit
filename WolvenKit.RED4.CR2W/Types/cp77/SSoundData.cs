using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSoundData : CVariable
	{
		private CName _widgetAudioName;
		private CName _onPressKey;
		private CName _onReleaseKey;
		private CName _onHoverOverKey;
		private CName _onHoverOutKey;

		[Ordinal(0)] 
		[RED("widgetAudioName")] 
		public CName WidgetAudioName
		{
			get
			{
				if (_widgetAudioName == null)
				{
					_widgetAudioName = (CName) CR2WTypeManager.Create("CName", "widgetAudioName", cr2w, this);
				}
				return _widgetAudioName;
			}
			set
			{
				if (_widgetAudioName == value)
				{
					return;
				}
				_widgetAudioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onPressKey")] 
		public CName OnPressKey
		{
			get
			{
				if (_onPressKey == null)
				{
					_onPressKey = (CName) CR2WTypeManager.Create("CName", "onPressKey", cr2w, this);
				}
				return _onPressKey;
			}
			set
			{
				if (_onPressKey == value)
				{
					return;
				}
				_onPressKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onReleaseKey")] 
		public CName OnReleaseKey
		{
			get
			{
				if (_onReleaseKey == null)
				{
					_onReleaseKey = (CName) CR2WTypeManager.Create("CName", "onReleaseKey", cr2w, this);
				}
				return _onReleaseKey;
			}
			set
			{
				if (_onReleaseKey == value)
				{
					return;
				}
				_onReleaseKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("onHoverOverKey")] 
		public CName OnHoverOverKey
		{
			get
			{
				if (_onHoverOverKey == null)
				{
					_onHoverOverKey = (CName) CR2WTypeManager.Create("CName", "onHoverOverKey", cr2w, this);
				}
				return _onHoverOverKey;
			}
			set
			{
				if (_onHoverOverKey == value)
				{
					return;
				}
				_onHoverOverKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("onHoverOutKey")] 
		public CName OnHoverOutKey
		{
			get
			{
				if (_onHoverOutKey == null)
				{
					_onHoverOutKey = (CName) CR2WTypeManager.Create("CName", "onHoverOutKey", cr2w, this);
				}
				return _onHoverOutKey;
			}
			set
			{
				if (_onHoverOutKey == value)
				{
					return;
				}
				_onHoverOutKey = value;
				PropertySet(this);
			}
		}

		public SSoundData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
