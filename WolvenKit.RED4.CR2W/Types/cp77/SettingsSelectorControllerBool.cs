using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerBool : inkSettingsSelectorController
	{
		private inkWidgetReference _onState;
		private inkWidgetReference _offState;
		private inkWidgetReference _onStateBody;
		private inkWidgetReference _offStateBody;

		[Ordinal(15)] 
		[RED("onState")] 
		public inkWidgetReference OnState
		{
			get
			{
				if (_onState == null)
				{
					_onState = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "onState", cr2w, this);
				}
				return _onState;
			}
			set
			{
				if (_onState == value)
				{
					return;
				}
				_onState = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("offState")] 
		public inkWidgetReference OffState
		{
			get
			{
				if (_offState == null)
				{
					_offState = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "offState", cr2w, this);
				}
				return _offState;
			}
			set
			{
				if (_offState == value)
				{
					return;
				}
				_offState = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("onStateBody")] 
		public inkWidgetReference OnStateBody
		{
			get
			{
				if (_onStateBody == null)
				{
					_onStateBody = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "onStateBody", cr2w, this);
				}
				return _onStateBody;
			}
			set
			{
				if (_onStateBody == value)
				{
					return;
				}
				_onStateBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("offStateBody")] 
		public inkWidgetReference OffStateBody
		{
			get
			{
				if (_offStateBody == null)
				{
					_offStateBody = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "offStateBody", cr2w, this);
				}
				return _offStateBody;
			}
			set
			{
				if (_offStateBody == value)
				{
					return;
				}
				_offStateBody = value;
				PropertySet(this);
			}
		}

		public SettingsSelectorControllerBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
