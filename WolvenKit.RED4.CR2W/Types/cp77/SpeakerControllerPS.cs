using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeakerControllerPS : ScriptableDeviceComponentPS
	{
		private SpeakerSetup _speakerSetup;
		private CName _currentValue;
		private CName _previousValue;

		[Ordinal(103)] 
		[RED("speakerSetup")] 
		public SpeakerSetup SpeakerSetup
		{
			get
			{
				if (_speakerSetup == null)
				{
					_speakerSetup = (SpeakerSetup) CR2WTypeManager.Create("SpeakerSetup", "speakerSetup", cr2w, this);
				}
				return _speakerSetup;
			}
			set
			{
				if (_speakerSetup == value)
				{
					return;
				}
				_speakerSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("currentValue")] 
		public CName CurrentValue
		{
			get
			{
				if (_currentValue == null)
				{
					_currentValue = (CName) CR2WTypeManager.Create("CName", "currentValue", cr2w, this);
				}
				return _currentValue;
			}
			set
			{
				if (_currentValue == value)
				{
					return;
				}
				_currentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("previousValue")] 
		public CName PreviousValue
		{
			get
			{
				if (_previousValue == null)
				{
					_previousValue = (CName) CR2WTypeManager.Create("CName", "previousValue", cr2w, this);
				}
				return _previousValue;
			}
			set
			{
				if (_previousValue == value)
				{
					return;
				}
				_previousValue = value;
				PropertySet(this);
			}
		}

		public SpeakerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
