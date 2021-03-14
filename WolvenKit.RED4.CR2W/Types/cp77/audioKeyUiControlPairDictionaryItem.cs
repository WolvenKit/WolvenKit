using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioKeyUiControlPairDictionaryItem : audioInlinedAudioMetadata
	{
		private CName _key;
		private audioUiControl _value;

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CName) CR2WTypeManager.Create("CName", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioUiControl Value
		{
			get
			{
				if (_value == null)
				{
					_value = (audioUiControl) CR2WTypeManager.Create("audioUiControl", "value", cr2w, this);
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

		public audioKeyUiControlPairDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
