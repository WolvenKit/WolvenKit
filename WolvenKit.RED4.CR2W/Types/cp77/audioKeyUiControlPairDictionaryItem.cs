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
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioUiControl Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public audioKeyUiControlPairDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
